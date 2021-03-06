﻿namespace Clide
{
    using System.Collections.Generic;

    /// <summary>
    /// Project configuration information
    /// </summary>
    public interface IProjectConfiguration
    {
        /// <summary>
        /// Gets the combined configuration and platform that makes 
        /// the configuration name for use in <see cref="IProjectNode.PropertiesFor"/> 
		/// and <see cref="IProjectNode.UserPropertiesFor"/>, 
        /// such as "Debug|AnyCPU".
        /// </summary>
        string ActiveConfigurationName { get; }

        /// <summary>
        /// Gets the active project configuration.
        /// </summary>
        string ActiveConfiguration { get; }

        /// <summary>
        /// Gets the active target platform.
        /// </summary>
        string ActivePlatform { get; }

        /// <summary>
        /// Gets all the configuration names.
        /// </summary>
        IEnumerable<string> Configurations { get; }

        /// <summary>
        /// Gets all the target platform names.
        /// </summary>
        IEnumerable<string> Platforms { get; }
    }
}
