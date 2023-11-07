// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SelfHelp.Models
{
    public partial class AutomatedCheckResult
    {
        internal static AutomatedCheckResult DeserializeAutomatedCheckResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> result = default;
            Optional<AutomatedCheckResultType> type = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("result"u8))
                {
                    result = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = new AutomatedCheckResultType(property.Value.GetString());
                    continue;
                }
            }
            return new AutomatedCheckResult(result.Value, Optional.ToNullable(type));
        }
    }
}
