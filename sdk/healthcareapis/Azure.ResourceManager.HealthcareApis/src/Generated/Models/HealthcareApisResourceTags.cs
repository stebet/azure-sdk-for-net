// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.HealthcareApis.Models
{
    /// <summary> List of key value pairs that describe the resource. This will overwrite the existing tags. </summary>
    public partial class HealthcareApisResourceTags
    {
        /// <summary> Initializes a new instance of HealthcareApisResourceTags. </summary>
        public HealthcareApisResourceTags()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of HealthcareApisResourceTags. </summary>
        /// <param name="tags"> Resource tags. </param>
        internal HealthcareApisResourceTags(IDictionary<string, string> tags)
        {
            Tags = tags;
        }

        /// <summary> Resource tags. </summary>
        public IDictionary<string, string> Tags { get; }
    }
}
