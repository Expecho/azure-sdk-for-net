// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.AI.TextAnalytics.Legacy
{
    internal partial class CustomEntitiesTaskResult
    {
        internal static CustomEntitiesTaskResult DeserializeCustomEntitiesTaskResult(JsonElement element)
        {
            Optional<CustomEntitiesResult> results = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("results"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    results = CustomEntitiesResult.DeserializeCustomEntitiesResult(property.Value);
                    continue;
                }
            }
            return new CustomEntitiesTaskResult(results.Value);
        }
    }
}
