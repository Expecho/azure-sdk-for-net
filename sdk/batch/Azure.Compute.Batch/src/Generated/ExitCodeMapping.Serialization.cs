// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure;
using Azure.Core;

namespace Azure.Compute.Batch
{
    public partial class ExitCodeMapping : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("code"u8);
            writer.WriteNumberValue(Code);
            writer.WritePropertyName("exitOptions"u8);
            writer.WriteObjectValue(ExitOptions);
            writer.WriteEndObject();
        }

        internal static ExitCodeMapping DeserializeExitCodeMapping(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int code = default;
            ExitOptions exitOptions = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("code"u8))
                {
                    code = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("exitOptions"u8))
                {
                    exitOptions = ExitOptions.DeserializeExitOptions(property.Value);
                    continue;
                }
            }
            return new ExitCodeMapping(code, exitOptions);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static ExitCodeMapping FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeExitCodeMapping(document.RootElement);
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
