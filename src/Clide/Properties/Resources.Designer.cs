﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Clide.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Clide.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The command handler &apos;{0}&apos; cannot be used because an existing one is already registered for the command type &apos;{1}&apos;..
        /// </summary>
        internal static string CommandBus_DuplicateHandler {
            get {
                return ResourceManager.GetString("CommandBus_DuplicateHandler", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Command handler &apos;{0}&apos; does not implement ICommandHandler or IAsyncCommandHandler generic interfaces..
        /// </summary>
        internal static string CommandBus_InvalidHandler {
            get {
                return ResourceManager.GetString("CommandBus_InvalidHandler", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The command handler &apos;{0}&apos; does not implement the required interface ICommandHandler&lt;{1}, {2}&gt; or IAsyncCommandHandler&lt;{1}, {2}&gt; to return the value expected by the command execution..
        /// </summary>
        internal static string CommandBus_MissingReturnHandler {
            get {
                return ResourceManager.GetString("CommandBus_MissingReturnHandler", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Project &apos;{0}&apos; is not based on MSBuild. Configuration-specific properties cannot be retrieved or set using the standard dynamic properties..
        /// </summary>
        internal static string ConfigProjectProperties_NonMsBuildProject {
            get {
                return ResourceManager.GetString("ConfigProjectProperties_NonMsBuildProject", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Attempted to set property &apos;{0}&apos; for configuration &apos;{1}&apos; on project &apos;{2}&apos; which is not based on MSBuild. Configuration-specific user properties cannot be retrieved or set using the standard dynamic properties..
        /// </summary>
        internal static string ConfigProjectProperties_SetNonMsBuildProject {
            get {
                return ResourceManager.GetString("ConfigProjectProperties_SetNonMsBuildProject", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Project &apos;{0}&apos; is not based on MSBuild. Configuration-specific properties for &apos;{1}&apos; cannot be retrieved or set using the standard dynamic properties..
        /// </summary>
        internal static string ConfigUserProjectProperties_NonMsBuildProject {
            get {
                return ResourceManager.GetString("ConfigUserProjectProperties_NonMsBuildProject", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Attempted to set property &apos;{0}&apos; for configuration &apos;{1}&apos; on project &apos;{2}&apos; which is not based on MSBuild. Configuration-specific user properties cannot be retrieved or set using the standard dynamic properties..
        /// </summary>
        internal static string ConfigUserProjectProperties_SetNonMsBuildProject {
            get {
                return ResourceManager.GetString("ConfigUserProjectProperties_SetNonMsBuildProject", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot set null value for item property {0}..
        /// </summary>
        internal static string ItemProperties_InvalidNullValue {
            get {
                return ResourceManager.GetString("ItemProperties_InvalidNullValue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Creating output pane &apos;{0}&apos; since it doesn&apos;t exist already..
        /// </summary>
        internal static string OutputWindowManager_CreatingPane {
            get {
                return ResourceManager.GetString("OutputWindowManager_CreatingPane", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to create output window pane &apos;{0}&apos;..
        /// </summary>
        internal static string OutputWindowManager_FailedToCreatePane {
            get {
                return ResourceManager.GetString("OutputWindowManager_FailedToCreatePane", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Retrieving potentially existing output pane &apos;{0}&apos;..
        /// </summary>
        internal static string OutputWindowManager_RetrievingPane {
            get {
                return ResourceManager.GetString("OutputWindowManager_RetrievingPane", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Initializing trace output pane &apos;{0}&apos;..
        /// </summary>
        internal static string OutputWindowManager_TraceInitializing {
            get {
                return ResourceManager.GetString("OutputWindowManager_TraceInitializing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The template {0} ({1}) could not be found.
        /// </summary>
        internal static string ProjectContainerNode_TemplateNotFound {
            get {
                return ResourceManager.GetString("ProjectContainerNode_TemplateNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to unfold template {0} ({1}).
        /// </summary>
        internal static string ProjectContainerNode_UnfoldTemplateFailed {
            get {
                return ResourceManager.GetString("ProjectContainerNode_UnfoldTemplateFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to find {0} in {1}.
        /// </summary>
        internal static string ProjectItemContainerNode_ItemNotFound {
            get {
                return ResourceManager.GetString("ProjectItemContainerNode_ItemNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to add folder {0} to {1}..
        /// </summary>
        internal static string ProjectNode_AddFolderFailed {
            get {
                return ResourceManager.GetString("ProjectNode_AddFolderFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Creating project folders is not supported by project {0}. Failed to create folder {1}..
        /// </summary>
        internal static string ProjectNode_AddFolderNotSupported {
            get {
                return ResourceManager.GetString("ProjectNode_AddFolderNotSupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to add project reference {0} to {1}..
        /// </summary>
        internal static string ProjectNode_AddProjectReferenceFailed {
            get {
                return ResourceManager.GetString("ProjectNode_AddProjectReferenceFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Adding project reference is not supported by project {0}..
        /// </summary>
        internal static string ProjectNode_AddProjectReferenceNotSupported {
            get {
                return ResourceManager.GetString("ProjectNode_AddProjectReferenceNotSupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Required dependency &apos;{0}&apos; was not found..
        /// </summary>
        internal static string ServiceLocator_MissingDependency {
            get {
                return ResourceManager.GetString("ServiceLocator_MissingDependency", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Object has already been initialized..
        /// </summary>
        internal static string Settings_AlreadyInitialized {
            get {
                return ResourceManager.GetString("Settings_AlreadyInitialized", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to EndEdit invoked without corresponding BeginEdit..
        /// </summary>
        internal static string Settings_EndEditWithoutBeginEdit {
            get {
                return ResourceManager.GetString("Settings_EndEditWithoutBeginEdit", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to EndInit invoked without corresponding BeginInit..
        /// </summary>
        internal static string Settings_EndInitWithoutBeginInit {
            get {
                return ResourceManager.GetString("Settings_EndInitWithoutBeginInit", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to restore original state when editing was cancelled..
        /// </summary>
        internal static string Settings_FailedToRestore {
            get {
                return ResourceManager.GetString("Settings_FailedToRestore", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Settings successfully saved..
        /// </summary>
        internal static string Settings_TraceSaved {
            get {
                return ResourceManager.GetString("Settings_TraceSaved", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot persist setting value of type &apos;{0}&apos; from property &apos;{1}.{2}&apos;. An appropriate type converter that can convert the value to a string is required..
        /// </summary>
        internal static string SettingsManager_CannotSaveAsString {
            get {
                return ResourceManager.GetString("SettingsManager_CannotSaveAsString", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to read settings class &apos;{0}&apos; from the settings store..
        /// </summary>
        internal static string SettingsManager_FailedToRead {
            get {
                return ResourceManager.GetString("SettingsManager_FailedToRead", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot assign value of type &apos;{0}&apos; to property &apos;{1}.{2}&apos; of type &apos;{4}&apos;. An appropriate type converter is required..
        /// </summary>
        internal static string SettingsManager_InvalidValue {
            get {
                return ResourceManager.GetString("SettingsManager_InvalidValue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Selecting element &apos;{0}&apos; is not supported by the underlying project type..
        /// </summary>
        internal static string SolutionExplorerNode_SelectionUnsupported {
            get {
                return ResourceManager.GetString("SolutionExplorerNode_SelectionUnsupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The solution file &apos;{0}&apos; is invalid..
        /// </summary>
        internal static string SolutionNode_InvalidSolutionFile {
            get {
                return ResourceManager.GetString("SolutionNode_InvalidSolutionFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Project &apos;{0}&apos; is not based on MSBuild. User properties cannot be retrieved or set using the standard dynamic properties..
        /// </summary>
        internal static string UserProjectProperties_NonMsBuildProject {
            get {
                return ResourceManager.GetString("UserProjectProperties_NonMsBuildProject", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Attempted to set property &apos;{0}&apos; on project &apos;{1}&apos; which is not based on MSBuild. User properties cannot be retrieved or set using the standard dynamic properties..
        /// </summary>
        internal static string UserProjectProperties_SetNonMsBuildProject {
            get {
                return ResourceManager.GetString("UserProjectProperties_SetNonMsBuildProject", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Attempted to execute command &apos;{0}&apos; ({1}) but current command status does not allow it..
        /// </summary>
        internal static string VsCommandExtensionAdapter_CannotExecute {
            get {
                return ResourceManager.GetString("VsCommandExtensionAdapter_CannotExecute", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Command did not execute successfully due to an unexpected exception. Please check the output window for additional information..
        /// </summary>
        internal static string VsCommandExtensionAdapter_ExecuteShieldMessage {
            get {
                return ResourceManager.GetString("VsCommandExtensionAdapter_ExecuteShieldMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Executing command &apos;{0}&apos; ({1})..
        /// </summary>
        internal static string VsCommandExtensionAdapter_ExecutingCommand {
            get {
                return ResourceManager.GetString("VsCommandExtensionAdapter_ExecutingCommand", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Command could not determine its current status due to an unexpected exception. Please check the output window for additional information..
        /// </summary>
        internal static string VsCommandExtensionAdapter_QueryStatusShieldMessage {
            get {
                return ResourceManager.GetString("VsCommandExtensionAdapter_QueryStatusShieldMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not locate any instances of contract {0}..
        /// </summary>
        internal static string VsServiceLocator_NoInstanceForContract {
            get {
                return ResourceManager.GetString("VsServiceLocator_NoInstanceForContract", resourceCulture);
            }
        }
    }
}
