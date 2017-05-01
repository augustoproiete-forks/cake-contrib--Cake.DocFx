﻿using System.Collections.Generic;
using Cake.Core.IO;
using Cake.Core.Tooling;

namespace Cake.DocFx
{
    /// <summary>
    /// Contains settings used by <see cref="DocFxBuildRunner"/>.
    /// </summary>
    public class DocFxBuildSettings : ToolSettings
    {
        private readonly Dictionary<string, string> _globalMetadata = new Dictionary<string, string>();

        /// <summary>
        /// Gets or sets the output folder. The default is _site, and is configured in the 'build' 
        /// section of docfx.json.
        /// </summary>
        public DirectoryPath OutputPath { get; set; }

        /// <summary>
        /// Gets or sets the template path to use. If not specified, the default template configured 
        /// in the 'build' section of docfx.json will be used.
        /// </summary>
        public DirectoryPath TemplateFolder { get; set; }

        /// <summary>
        /// Gets global metadata.
        /// It overrides the globalMetadata settings from the config file.
        /// See <see cref="DocFxGlobalMetadata"/> for constants for metadata keys.
        /// </summary>
        public Dictionary<string, string> GlobalMetadata => _globalMetadata;

        /// <summary>
        /// Gets or sets a value indicating whether to enable previewing of the generated documentation
        /// in a built in web server. 
        /// </summary>
        public bool Serve { get; set; }
    }
}