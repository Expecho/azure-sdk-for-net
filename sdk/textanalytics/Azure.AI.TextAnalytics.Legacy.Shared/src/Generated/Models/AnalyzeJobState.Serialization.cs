// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.AI.TextAnalytics.Legacy.Models;
using Azure.Core;

namespace Azure.AI.TextAnalytics.Legacy
{
    internal partial class AnalyzeJobState
    {
        internal static AnalyzeJobState DeserializeAnalyzeJobState(JsonElement element)
        {
            TasksStateTasks tasks = default;
            Optional<IReadOnlyList<TextAnalyticsError>> errors = default;
            Optional<RequestStatistics> statistics = default;
            Optional<string> nextLink = default;
            Optional<string> displayName = default;
            DateTimeOffset createdDateTime = default;
            Optional<DateTimeOffset> expirationDateTime = default;
            Guid jobId = default;
            DateTimeOffset lastUpdateDateTime = default;
            State status = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tasks"))
                {
                    tasks = TasksStateTasks.DeserializeTasksStateTasks(property.Value);
                    continue;
                }
                if (property.NameEquals("errors"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<TextAnalyticsError> array = new List<TextAnalyticsError>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(TextAnalyticsError.DeserializeTextAnalyticsError(item));
                    }
                    errors = array;
                    continue;
                }
                if (property.NameEquals("statistics"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    statistics = RequestStatistics.DeserializeRequestStatistics(property.Value);
                    continue;
                }
                if (property.NameEquals("@nextLink"))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("displayName"))
                {
                    displayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("createdDateTime"))
                {
                    createdDateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("expirationDateTime"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    expirationDateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("jobId"))
                {
                    jobId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("lastUpdateDateTime"))
                {
                    lastUpdateDateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("status"))
                {
                    status = property.Value.GetString().ToState();
                    continue;
                }
            }
            return new AnalyzeJobState(createdDateTime, Optional.ToNullable(expirationDateTime), jobId, lastUpdateDateTime, status, displayName.Value, tasks, Optional.ToList(errors), statistics.Value, nextLink.Value);
        }
    }
}
