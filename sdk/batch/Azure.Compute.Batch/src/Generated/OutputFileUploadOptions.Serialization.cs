// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure;
using Azure.Core;

namespace Azure.Compute.Batch
{
    public partial class OutputFileUploadOptions : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("uploadCondition"u8);
            writer.WriteStringValue(UploadCondition.ToString());
            writer.WriteEndObject();
        }

        internal static OutputFileUploadOptions DeserializeOutputFileUploadOptions(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            OutputFileUploadCondition uploadCondition = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("uploadCondition"u8))
                {
                    uploadCondition = new OutputFileUploadCondition(property.Value.GetString());
                    continue;
                }
            }
            return new OutputFileUploadOptions(uploadCondition);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static OutputFileUploadOptions FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeOutputFileUploadOptions(document.RootElement);
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
