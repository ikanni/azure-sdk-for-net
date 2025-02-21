// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    internal partial class TriggerListResponse
    {
        internal static TriggerListResponse DeserializeTriggerListResponse(JsonElement element)
        {
            IReadOnlyList<TriggerResource> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    List<TriggerResource> array = new List<TriggerResource>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(TriggerResource.DeserializeTriggerResource(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new TriggerListResponse(value, nextLink.Value);
        }
    }
}
