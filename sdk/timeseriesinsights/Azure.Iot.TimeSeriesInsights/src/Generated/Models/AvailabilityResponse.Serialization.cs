// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Iot.TimeSeriesInsights
{
    public partial class AvailabilityResponse
    {
        internal static AvailabilityResponse DeserializeAvailabilityResponse(JsonElement element)
        {
            Optional<EventAvailability> availability = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("availability"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    availability = EventAvailability.DeserializeEventAvailability(property.Value);
                    continue;
                }
            }
            return new AvailabilityResponse(availability.Value);
        }
    }
}
