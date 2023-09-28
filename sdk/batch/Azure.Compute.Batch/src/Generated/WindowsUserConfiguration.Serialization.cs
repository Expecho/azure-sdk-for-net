// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure;
using Azure.Core;

namespace Azure.Compute.Batch
{
    public partial class WindowsUserConfiguration : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(LoginMode))
            {
                writer.WritePropertyName("loginMode"u8);
                writer.WriteStringValue(LoginMode.Value.ToString());
            }
            writer.WriteEndObject();
        }

        internal static WindowsUserConfiguration DeserializeWindowsUserConfiguration(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<LoginMode> loginMode = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("loginMode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    loginMode = new LoginMode(property.Value.GetString());
                    continue;
                }
            }
            return new WindowsUserConfiguration(Optional.ToNullable(loginMode));
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static WindowsUserConfiguration FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeWindowsUserConfiguration(document.RootElement);
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
