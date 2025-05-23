// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Iot.TimeSeriesInsights
{
    /// <summary> Information about an API error. </summary>
    internal partial class TsiError
    {
        /// <summary> Initializes a new instance of TsiError. </summary>
        internal TsiError()
        {
        }

        /// <summary> Initializes a new instance of TsiError. </summary>
        /// <param name="error"> A particular API error with an error code and a message. </param>
        internal TsiError(TimeSeriesOperationError error)
        {
            Error = error;
        }

        /// <summary> A particular API error with an error code and a message. </summary>
        public TimeSeriesOperationError Error { get; }
    }
}
