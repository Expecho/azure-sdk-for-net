// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure;
using Azure.Core;

namespace Azure.Compute.Batch
{
    public partial class FileProperties
    {
        internal static FileProperties DeserializeFileProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<DateTimeOffset> creationTime = default;
            DateTimeOffset lastModified = default;
            int contentLength = default;
            Optional<string> contentType = default;
            Optional<string> fileMode = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("creationTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    creationTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastModified"u8))
                {
                    lastModified = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("contentLength"u8))
                {
                    contentLength = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("contentType"u8))
                {
                    contentType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("fileMode"u8))
                {
                    fileMode = property.Value.GetString();
                    continue;
                }
            }
            return new FileProperties(Optional.ToNullable(creationTime), lastModified, contentLength, contentType.Value, fileMode.Value);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static FileProperties FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeFileProperties(document.RootElement);
        }
    }
}
