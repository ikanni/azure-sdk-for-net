// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.AI.DocumentTranslation
{
    public partial class TranslationGlossary : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("glossaryUrl");
            writer.WriteStringValue(GlossaryUri.AbsoluteUri);
            if (Optional.IsDefined(FormatVersion))
            {
                writer.WritePropertyName("format");
                writer.WriteStringValue(FormatVersion);
            }
            if (Optional.IsDefined(Version))
            {
                writer.WritePropertyName("version");
                writer.WriteStringValue(Version);
            }
            if (Optional.IsDefined(StorageSource))
            {
                writer.WritePropertyName("storageSource");
                writer.WriteStringValue(StorageSource);
            }
            writer.WriteEndObject();
        }
    }
}
