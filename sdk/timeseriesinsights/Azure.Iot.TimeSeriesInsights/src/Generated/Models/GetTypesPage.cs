// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Iot.TimeSeriesInsights
{
    /// <summary> Partial list of time series types returned in a single request. </summary>
    public partial class GetTypesPage : PagedResponse
    {
        /// <summary> Initializes a new instance of GetTypesPage. </summary>
        internal GetTypesPage()
        {
            Types = new ChangeTrackingList<TimeSeriesType>();
        }

        /// <summary> Initializes a new instance of GetTypesPage. </summary>
        /// <param name="continuationToken"> If returned, this means that current results represent a partial result. Continuation token allows to get the next page of results. To get the next page of query results, send the same request with continuation token parameter in &quot;x-ms-continuation&quot; HTTP header. </param>
        /// <param name="types"> Partial list of time series types returned in a single request. Can be empty if server was unable to fill the page with more types in this request, or there is no more types when continuation token is null. </param>
        internal GetTypesPage(string continuationToken, IReadOnlyList<TimeSeriesType> types) : base(continuationToken)
        {
            Types = types;
        }

        /// <summary> Partial list of time series types returned in a single request. Can be empty if server was unable to fill the page with more types in this request, or there is no more types when continuation token is null. </summary>
        public IReadOnlyList<TimeSeriesType> Types { get; }
    }
}
