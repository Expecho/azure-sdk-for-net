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
    internal partial class LicenseProfilesListResult
    {
        internal static LicenseProfilesListResult DeserializeLicenseProfilesListResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<HybridComputeLicenseProfileData> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    List<HybridComputeLicenseProfileData> array = new List<HybridComputeLicenseProfileData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(HybridComputeLicenseProfileData.DeserializeHybridComputeLicenseProfileData(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new LicenseProfilesListResult(value, nextLink.Value);
        }
    }
}
