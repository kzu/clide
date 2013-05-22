﻿#region BSD License
/* 
Copyright (c) 2012, Clarius Consulting
All rights reserved.

Redistribution and use in source and binary forms, with or without modification, are permitted provided that the following conditions are met:

* Redistributions of source code must retain the above copyright notice, this list of conditions and the following disclaimer.
* Redistributions in binary form must reproduce the above copyright notice, this list of conditions and the following disclaimer in the documentation and/or other materials provided with the distribution.

THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
*/
#endregion
namespace Clide.VisualStudio
{
    using System;
    using System.Globalization;
    using System.Linq;
    using System.Reflection;
    using Microsoft.VisualStudio.ComponentModelHost;
    using Microsoft.VisualStudio.Shell;

    /// <summary>
    /// Locates services within Visual Studio. 
    /// </summary>
    public static class ServiceLocator
    {
        private static readonly IServiceProvider dteProvider = new DteServiceProvider();
        private static readonly VsServiceProvider vsProvider = new VsServiceProvider();
        private static readonly ComponentModelProvider cmProvider = new ComponentModelProvider(vsProvider);

        private static IServiceProvider hostingPackage;
        private static IServiceProvider globalProvider = new FallbackServiceProvider(
            // DTE, ComponentModel, Global Package
            dteProvider, new FallbackServiceProvider(
                cmProvider, 
                    vsProvider));

        public static void Initialize(IServiceProvider hostingPackage)
        {
            ServiceLocator.hostingPackage = hostingPackage;
            // Now we prepent the hosting package at the beginning of the chain.
            globalProvider = new FallbackServiceProvider(
                // Hosting package, DTE, ComponentModel, Global Package
                hostingPackage, new FallbackServiceProvider(
                    dteProvider, new FallbackServiceProvider(
                        cmProvider,
                            vsProvider)));
        }

        public static IServiceProvider GlobalProvider
        {
            get { return globalProvider; }
        }

        private class FallbackServiceProvider : IServiceProvider
        {
            private IServiceProvider primary;
            private IServiceProvider fallback;

            public FallbackServiceProvider(IServiceProvider primary, IServiceProvider fallback)
            {
                this.primary = primary;
                this.fallback = fallback;
            }

            public object GetService(Type serviceType)
            {
                return primary.GetService(serviceType) ?? fallback.GetService(serviceType);
            }
        }

        private class DteServiceProvider : IServiceProvider
        {
            private static Lazy<IServiceProvider> globalProvider = new Lazy<IServiceProvider>(GetGlobalProvider);

            public object GetService(Type serviceType)
            {
                return globalProvider.Value.GetService(serviceType);
            }

            private static IServiceProvider GetGlobalProvider()
            {
                var dte = Package.GetGlobalService(typeof(EnvDTE.DTE));
                var ole = dte as Microsoft.VisualStudio.OLE.Interop.IServiceProvider;
                return new ServiceProvider(ole);
            }
        }

        private class ComponentModelProvider : IServiceProvider
        {
            private static MethodInfo getService = typeof(IComponentModel).GetMethod("GetService");
            private IComponentModel componentModel;

            public ComponentModelProvider(IServiceProvider parentProvider)
            {
                componentModel = parentProvider.GetService<SComponentModel, IComponentModel>();
            }

            public object GetService(Type serviceType)
            {
                // TODO: cache delegates per service type for performance.
                return getService.MakeGenericMethod(serviceType).Invoke(componentModel, null);
            }
        }

        private class VsServiceProvider : IServiceProvider
        {
            public object GetService(Type serviceType)
            {
                return Package.GetGlobalService(serviceType);
            }
        }
    }
}