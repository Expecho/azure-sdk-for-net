// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HDInsight.Containers.Models
{
    public partial class ClusterPoolComputeProfile : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("vmSize"u8);
            writer.WriteStringValue(VmSize);
            writer.WriteEndObject();
        }

        internal static ClusterPoolComputeProfile DeserializeClusterPoolComputeProfile(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string vmSize = default;
            Optional<int> count = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("vmSize"u8))
                {
                    vmSize = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("count"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    count = property.Value.GetInt32();
                    continue;
                }
            }
            return new ClusterPoolComputeProfile(vmSize, Optional.ToNullable(count));
        }
    }
}
