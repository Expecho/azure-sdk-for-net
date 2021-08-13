// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.CallingServer
{
    public partial class StopHoldMusicResult
    {
        internal static StopHoldMusicResult DeserializeStopHoldMusicResult(JsonElement element)
        {
            Optional<string> operationId = default;
            OperationStatus status = default;
            Optional<string> operationContext = default;
            Optional<ResultInfo> resultInfo = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("operationId"))
                {
                    operationId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("status"))
                {
                    status = new OperationStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("operationContext"))
                {
                    operationContext = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resultInfo"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    resultInfo = ResultInfo.DeserializeResultInfo(property.Value);
                    continue;
                }
            }
            return new StopHoldMusicResult(operationId.Value, status, operationContext.Value, resultInfo.Value);
        }
    }
}
