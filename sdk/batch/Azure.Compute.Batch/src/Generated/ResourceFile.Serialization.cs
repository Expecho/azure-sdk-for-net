// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure;
using Azure.Core;

namespace Azure.Compute.Batch
{
    public partial class ResourceFile : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(AutoStorageContainerName))
            {
                writer.WritePropertyName("autoStorageContainerName"u8);
                writer.WriteStringValue(AutoStorageContainerName);
            }
            if (Optional.IsDefined(StorageContainerUrl))
            {
                writer.WritePropertyName("storageContainerUrl"u8);
                writer.WriteStringValue(StorageContainerUrl);
            }
            if (Optional.IsDefined(HttpUrl))
            {
                writer.WritePropertyName("httpUrl"u8);
                writer.WriteStringValue(HttpUrl);
            }
            if (Optional.IsDefined(BlobPrefix))
            {
                writer.WritePropertyName("blobPrefix"u8);
                writer.WriteStringValue(BlobPrefix);
            }
            if (Optional.IsDefined(FilePath))
            {
                writer.WritePropertyName("filePath"u8);
                writer.WriteStringValue(FilePath);
            }
            if (Optional.IsDefined(FileMode))
            {
                writer.WritePropertyName("fileMode"u8);
                writer.WriteStringValue(FileMode);
            }
            if (Optional.IsDefined(IdentityReference))
            {
                writer.WritePropertyName("identityReference"u8);
                writer.WriteObjectValue(IdentityReference);
            }
            writer.WriteEndObject();
        }

        internal static ResourceFile DeserializeResourceFile(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> autoStorageContainerName = default;
            Optional<string> storageContainerUrl = default;
            Optional<string> httpUrl = default;
            Optional<string> blobPrefix = default;
            Optional<string> filePath = default;
            Optional<string> fileMode = default;
            Optional<BatchNodeIdentityReference> identityReference = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("autoStorageContainerName"u8))
                {
                    autoStorageContainerName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("storageContainerUrl"u8))
                {
                    storageContainerUrl = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("httpUrl"u8))
                {
                    httpUrl = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("blobPrefix"u8))
                {
                    blobPrefix = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("filePath"u8))
                {
                    filePath = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("fileMode"u8))
                {
                    fileMode = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("identityReference"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    identityReference = BatchNodeIdentityReference.DeserializeBatchNodeIdentityReference(property.Value);
                    continue;
                }
            }
            return new ResourceFile(autoStorageContainerName.Value, storageContainerUrl.Value, httpUrl.Value, blobPrefix.Value, filePath.Value, fileMode.Value, identityReference.Value);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static ResourceFile FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeResourceFile(document.RootElement);
        }

        /// <summary> Convert into a Utf8JsonRequestContent. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }
    }
}
