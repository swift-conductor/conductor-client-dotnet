

using System.Collections.Generic;

namespace SwiftConductor.Client
{
    /// <summary>
    /// Represents a readable-only configuration contract.
    /// </summary>
    public interface IReadableConfiguration
    {
        /// <summary>
        /// Gets the base path.
        /// </summary>
        /// <value>Base path.</value>
        string BasePath { get; }

        /// <summary>
        /// Gets the date time format.
        /// </summary>
        /// <value>Date time foramt.</value>
        string DateTimeFormat { get; }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <value>Default header.</value>
        IDictionary<string, string> DefaultHeader { get; }

        /// <summary>
        /// Gets the temp folder path.
        /// </summary>
        /// <value>Temp folder path.</value>
        string TempFolderPath { get; }

        /// <summary>
        /// Gets the HTTP connection timeout (in milliseconds)
        /// </summary>
        /// <value>HTTP connection timeout.</value>
        int Timeout { get; }
    }
}
