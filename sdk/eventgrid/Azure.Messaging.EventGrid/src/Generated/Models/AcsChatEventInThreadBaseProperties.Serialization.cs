// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    public partial class AcsChatEventInThreadBaseProperties
    {
        internal static AcsChatEventInThreadBaseProperties DeserializeAcsChatEventInThreadBaseProperties(JsonElement element)
        {
            Optional<string> threadId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("threadId"))
                {
                    threadId = property.Value.GetString();
                    continue;
                }
            }
            return new AcsChatEventInThreadBaseProperties(threadId.Value);
        }
    }
}
