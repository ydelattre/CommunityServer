// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;

using Microsoft.Graph;

using Newtonsoft.Json;

// **NOTE** This file was generated by a tool and any changes will be overwritten.


namespace Microsoft.OneDrive.Sdk
{
    /// <summary>
    /// The type Identity.
    /// </summary>
    [DataContract]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class Identity
    {
    
        /// <summary>
        /// Gets or sets displayName.
        /// </summary>
        [DataMember(Name = "displayName", EmitDefaultValue = false, IsRequired = false)]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets id.
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false, IsRequired = false)]
        public string Id { get; set; }
    
        /// <summary>
        /// Gets or sets thumbnails.
        /// </summary>
        [DataMember(Name = "thumbnails", EmitDefaultValue = false, IsRequired = false)]
        public ThumbnailSet Thumbnails { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData(ReadData = true)]
        public IDictionary<string, object> AdditionalData { get; set; }
    
    }
}