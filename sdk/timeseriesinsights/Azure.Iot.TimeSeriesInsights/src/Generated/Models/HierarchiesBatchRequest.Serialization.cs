// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Iot.TimeSeriesInsights
{
    public partial class HierarchiesBatchRequest : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Get))
            {
                writer.WritePropertyName("get");
                writer.WriteObjectValue(Get);
            }
            if (Optional.IsCollectionDefined(Put))
            {
                writer.WritePropertyName("put");
                writer.WriteStartArray();
                foreach (var item in Put)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Delete))
            {
                writer.WritePropertyName("delete");
                writer.WriteObjectValue(Delete);
            }
            writer.WriteEndObject();
        }
    }
}
