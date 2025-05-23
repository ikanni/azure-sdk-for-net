// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Iot.TimeSeriesInsights
{
    /// <summary> Time series model settings including model name, Time Series ID properties and default type ID. </summary>
    public partial class TimeSeriesModelSettings
    {
        /// <summary> Initializes a new instance of TimeSeriesModelSettings. </summary>
        internal TimeSeriesModelSettings()
        {
            TimeSeriesIdProperties = new ChangeTrackingList<TimeSeriesIdProperty>();
        }

        /// <summary> Initializes a new instance of TimeSeriesModelSettings. </summary>
        /// <param name="name"> Time series model display name which is shown in the UX. Examples: &quot;Temperature Sensors&quot;, &quot;MyDevices&quot;. </param>
        /// <param name="timeSeriesIdProperties"> Time series ID properties defined during environment creation. </param>
        /// <param name="defaultTypeId"> Default type ID of the model that new time series instances will automatically belong to. </param>
        internal TimeSeriesModelSettings(string name, IReadOnlyList<TimeSeriesIdProperty> timeSeriesIdProperties, string defaultTypeId)
        {
            Name = name;
            TimeSeriesIdProperties = timeSeriesIdProperties;
            DefaultTypeId = defaultTypeId;
        }

        /// <summary> Time series model display name which is shown in the UX. Examples: &quot;Temperature Sensors&quot;, &quot;MyDevices&quot;. </summary>
        public string Name { get; }
        /// <summary> Time series ID properties defined during environment creation. </summary>
        public IReadOnlyList<TimeSeriesIdProperty> TimeSeriesIdProperties { get; }
        /// <summary> Default type ID of the model that new time series instances will automatically belong to. </summary>
        public string DefaultTypeId { get; }
    }
}
