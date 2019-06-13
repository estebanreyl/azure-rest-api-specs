// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.ContainerRegistry.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Changeable attributes
    /// </summary>
    public partial class ManifestChangeableAttributes
    {
        /// <summary>
        /// Initializes a new instance of the ManifestChangeableAttributes
        /// class.
        /// </summary>
        public ManifestChangeableAttributes()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ManifestChangeableAttributes
        /// class.
        /// </summary>
        /// <param name="deleteEnabled">Delete enabled</param>
        /// <param name="writeEnabled">Write enabled</param>
        /// <param name="listEnabled">List enabled</param>
        /// <param name="readEnabled">Read enabled</param>
        /// <param name="quarantineState">Quarantine state</param>
        /// <param name="quarantineDetails">Quarantine details</param>
        public ManifestChangeableAttributes(bool? deleteEnabled = default(bool?), bool? writeEnabled = default(bool?), bool? listEnabled = default(bool?), bool? readEnabled = default(bool?), string quarantineState = default(string), string quarantineDetails = default(string))
        {
            DeleteEnabled = deleteEnabled;
            WriteEnabled = writeEnabled;
            ListEnabled = listEnabled;
            ReadEnabled = readEnabled;
            QuarantineState = quarantineState;
            QuarantineDetails = quarantineDetails;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets delete enabled
        /// </summary>
        [JsonProperty(PropertyName = "deleteEnabled")]
        public bool? DeleteEnabled { get; set; }

        /// <summary>
        /// Gets or sets write enabled
        /// </summary>
        [JsonProperty(PropertyName = "writeEnabled")]
        public bool? WriteEnabled { get; set; }

        /// <summary>
        /// Gets or sets list enabled
        /// </summary>
        [JsonProperty(PropertyName = "listEnabled")]
        public bool? ListEnabled { get; set; }

        /// <summary>
        /// Gets or sets read enabled
        /// </summary>
        [JsonProperty(PropertyName = "readEnabled")]
        public bool? ReadEnabled { get; set; }

        /// <summary>
        /// Gets or sets quarantine state
        /// </summary>
        [JsonProperty(PropertyName = "quarantineState")]
        public string QuarantineState { get; set; }

        /// <summary>
        /// Gets or sets quarantine details
        /// </summary>
        [JsonProperty(PropertyName = "quarantineDetails")]
        public string QuarantineDetails { get; set; }

    }
}
