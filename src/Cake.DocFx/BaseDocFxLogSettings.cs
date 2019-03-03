﻿using Cake.Core.IO;
using Cake.Core.Tooling;

namespace Cake.DocFx
{
    /// <summary>
    /// Base class for all settings supporting logging.
    /// </summary>
    public abstract class BaseDocFxLogSettings : ToolSettings
    {
        /// <summary>
        /// Gets or sets the path and file name where the log file generated by DocFx will be saved.
        /// </summary>
        public FilePath LogPath { get; set; }

        /// <summary>
        /// Gets or sets to which log level will be logged.
        /// </summary>
        public DocFxLogLevel LogLevel { get; set; }

        /// <summary>
        /// Gets or sets the Git repository root folder.
        /// </summary>
        public DirectoryPath RepositoryRoot { get; set; }

        /// <summary>
        /// Gets or sets the correlation id used for logging.
        /// </summary>
        public string CorrelationId { get; set; }

        /// <summary>
        /// Gets or sets a value indicating if warnings should be treated as errors.
        /// </summary>
        public bool WarningsAsErrors { get; set; }
    }
}
