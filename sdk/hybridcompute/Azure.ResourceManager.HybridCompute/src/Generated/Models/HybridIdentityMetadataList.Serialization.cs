// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.HybridCompute;

namespace Azure.ResourceManager.HybridCompute.Models
{
    internal partial class HybridIdentityMetadataList
    {
        internal static HybridIdentityMetadataList DeserializeHybridIdentityMetadataList(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> nextLink = default;
            IReadOnlyList<HybridIdentityMetadataData> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("value"u8))
                {
                    List<HybridIdentityMetadataData> array = new List<HybridIdentityMetadataData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(HybridIdentityMetadataData.DeserializeHybridIdentityMetadataData(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new HybridIdentityMetadataList(nextLink.Value, value);
        }
    }
}
