// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;

namespace Azure.Compute.Batch
{
    public partial class ImageInformation
    {
        internal static ImageInformation DeserializeImageInformation(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string nodeAgentSKUId = default;
            ImageReference imageReference = default;
            OSType osType = default;
            Optional<IReadOnlyList<string>> capabilities = default;
            Optional<DateTimeOffset> batchSupportEndOfLife = default;
            VerificationType verificationType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("nodeAgentSKUId"u8))
                {
                    nodeAgentSKUId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("imageReference"u8))
                {
                    imageReference = ImageReference.DeserializeImageReference(property.Value);
                    continue;
                }
                if (property.NameEquals("osType"u8))
                {
                    osType = new OSType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("capabilities"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    capabilities = array;
                    continue;
                }
                if (property.NameEquals("batchSupportEndOfLife"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    batchSupportEndOfLife = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("verificationType"u8))
                {
                    verificationType = new VerificationType(property.Value.GetString());
                    continue;
                }
            }
            return new ImageInformation(nodeAgentSKUId, imageReference, osType, Optional.ToList(capabilities), Optional.ToNullable(batchSupportEndOfLife), verificationType);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static ImageInformation FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeImageInformation(document.RootElement);
        }
    }
}
