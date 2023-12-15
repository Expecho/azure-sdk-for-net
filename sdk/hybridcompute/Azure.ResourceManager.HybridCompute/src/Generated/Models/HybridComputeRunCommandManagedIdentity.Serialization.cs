// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HybridCompute.Models
{
    public partial class HybridComputeRunCommandManagedIdentity : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ClientId))
            {
                writer.WritePropertyName("clientId"u8);
                writer.WriteStringValue(ClientId.Value);
            }
            if (Optional.IsDefined(ObjectId))
            {
                writer.WritePropertyName("objectId"u8);
                writer.WriteStringValue(ObjectId.Value);
            }
            writer.WriteEndObject();
        }

        internal static HybridComputeRunCommandManagedIdentity DeserializeHybridComputeRunCommandManagedIdentity(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<Guid> clientId = default;
            Optional<Guid> objectId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("clientId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    clientId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("objectId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    objectId = property.Value.GetGuid();
                    continue;
                }
            }
            return new HybridComputeRunCommandManagedIdentity(Optional.ToNullable(clientId), Optional.ToNullable(objectId));
        }
    }
}
