// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.TextAnalytics.Legacy
{
    internal partial class PiiDocumentEntities
    {
        internal static PiiDocumentEntities DeserializePiiDocumentEntities(JsonElement element)
        {
            string id = default;
            string redactedText = default;
            IReadOnlyList<Entity> entities = default;
            IReadOnlyList<TextAnalyticsWarning> warnings = default;
            Optional<DocumentStatistics> statistics = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("redactedText"))
                {
                    redactedText = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("entities"))
                {
                    List<Entity> array = new List<Entity>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(Entity.DeserializeEntity(item));
                    }
                    entities = array;
                    continue;
                }
                if (property.NameEquals("warnings"))
                {
                    List<TextAnalyticsWarning> array = new List<TextAnalyticsWarning>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(TextAnalyticsWarning.DeserializeTextAnalyticsWarning(item));
                    }
                    warnings = array;
                    continue;
                }
                if (property.NameEquals("statistics"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    statistics = DocumentStatistics.DeserializeDocumentStatistics(property.Value);
                    continue;
                }
            }
            return new PiiDocumentEntities(id, redactedText, entities, warnings, statistics.Value);
        }
    }
}
