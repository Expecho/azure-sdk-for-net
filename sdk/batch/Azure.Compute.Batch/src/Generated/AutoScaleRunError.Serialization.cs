// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;

namespace Azure.Compute.Batch
{
    public partial class AutoScaleRunError
    {
        internal static AutoScaleRunError DeserializeAutoScaleRunError(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> code = default;
            Optional<string> message = default;
            Optional<IReadOnlyList<NameValuePair>> values = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("code"u8))
                {
                    code = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("message"u8))
                {
                    message = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("values"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<NameValuePair> array = new List<NameValuePair>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(NameValuePair.DeserializeNameValuePair(item));
                    }
                    values = array;
                    continue;
                }
            }
            return new AutoScaleRunError(code.Value, message.Value, Optional.ToList(values));
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static AutoScaleRunError FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeAutoScaleRunError(document.RootElement);
        }
    }
}
