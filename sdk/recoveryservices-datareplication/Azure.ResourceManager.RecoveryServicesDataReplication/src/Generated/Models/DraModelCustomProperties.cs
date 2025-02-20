// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.RecoveryServicesDataReplication.Models
{
    /// <summary>
    /// Dra model custom properties.
    /// Please note <see cref="DraModelCustomProperties"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="GeneralDraModelCustomProperties"/> and <see cref="VMwareDraModelCustomProperties"/>.
    /// </summary>
    public abstract partial class DraModelCustomProperties
    {
        /// <summary> Initializes a new instance of DraModelCustomProperties. </summary>
        protected DraModelCustomProperties()
        {
        }

        /// <summary> Initializes a new instance of DraModelCustomProperties. </summary>
        /// <param name="instanceType"> Gets or sets the instance type. </param>
        internal DraModelCustomProperties(string instanceType)
        {
            InstanceType = instanceType;
        }

        /// <summary> Gets or sets the instance type. </summary>
        internal string InstanceType { get; set; }
    }
}
