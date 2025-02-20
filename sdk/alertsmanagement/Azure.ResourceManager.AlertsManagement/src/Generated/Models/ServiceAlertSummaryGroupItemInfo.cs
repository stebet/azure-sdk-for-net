// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.AlertsManagement.Models
{
    /// <summary> Alerts summary group item. </summary>
    public partial class ServiceAlertSummaryGroupItemInfo
    {
        /// <summary> Initializes a new instance of ServiceAlertSummaryGroupItemInfo. </summary>
        public ServiceAlertSummaryGroupItemInfo()
        {
            Values = new ChangeTrackingList<ServiceAlertSummaryGroupItemInfo>();
        }

        /// <summary> Initializes a new instance of ServiceAlertSummaryGroupItemInfo. </summary>
        /// <param name="name"> Value of the aggregated field. </param>
        /// <param name="count"> Count of the aggregated field. </param>
        /// <param name="groupedBy"> Name of the field aggregated. </param>
        /// <param name="values"> List of the items. </param>
        internal ServiceAlertSummaryGroupItemInfo(string name, long? count, string groupedBy, IList<ServiceAlertSummaryGroupItemInfo> values)
        {
            Name = name;
            Count = count;
            GroupedBy = groupedBy;
            Values = values;
        }

        /// <summary> Value of the aggregated field. </summary>
        public string Name { get; set; }
        /// <summary> Count of the aggregated field. </summary>
        public long? Count { get; set; }
        /// <summary> Name of the field aggregated. </summary>
        public string GroupedBy { get; set; }
        /// <summary> List of the items. </summary>
        public IList<ServiceAlertSummaryGroupItemInfo> Values { get; }
    }
}
