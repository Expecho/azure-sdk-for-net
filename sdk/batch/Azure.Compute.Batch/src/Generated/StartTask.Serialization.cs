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
    public partial class StartTask : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("commandLine"u8);
            writer.WriteStringValue(CommandLine);
            if (Optional.IsDefined(ContainerSettings))
            {
                writer.WritePropertyName("containerSettings"u8);
                writer.WriteObjectValue(ContainerSettings);
            }
            if (Optional.IsCollectionDefined(ResourceFiles))
            {
                writer.WritePropertyName("resourceFiles"u8);
                writer.WriteStartArray();
                foreach (var item in ResourceFiles)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(EnvironmentSettings))
            {
                writer.WritePropertyName("environmentSettings"u8);
                writer.WriteStartArray();
                foreach (var item in EnvironmentSettings)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(UserIdentity))
            {
                writer.WritePropertyName("userIdentity"u8);
                writer.WriteObjectValue(UserIdentity);
            }
            if (Optional.IsDefined(MaxTaskRetryCount))
            {
                writer.WritePropertyName("maxTaskRetryCount"u8);
                writer.WriteNumberValue(MaxTaskRetryCount.Value);
            }
            if (Optional.IsDefined(WaitForSuccess))
            {
                writer.WritePropertyName("waitForSuccess"u8);
                writer.WriteBooleanValue(WaitForSuccess.Value);
            }
            writer.WriteEndObject();
        }

        internal static StartTask DeserializeStartTask(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string commandLine = default;
            Optional<TaskContainerSettings> containerSettings = default;
            Optional<IList<ResourceFile>> resourceFiles = default;
            Optional<IList<EnvironmentSetting>> environmentSettings = default;
            Optional<UserIdentity> userIdentity = default;
            Optional<int> maxTaskRetryCount = default;
            Optional<bool> waitForSuccess = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("commandLine"u8))
                {
                    commandLine = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("containerSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    containerSettings = TaskContainerSettings.DeserializeTaskContainerSettings(property.Value);
                    continue;
                }
                if (property.NameEquals("resourceFiles"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ResourceFile> array = new List<ResourceFile>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ResourceFile.DeserializeResourceFile(item));
                    }
                    resourceFiles = array;
                    continue;
                }
                if (property.NameEquals("environmentSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<EnvironmentSetting> array = new List<EnvironmentSetting>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(EnvironmentSetting.DeserializeEnvironmentSetting(item));
                    }
                    environmentSettings = array;
                    continue;
                }
                if (property.NameEquals("userIdentity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    userIdentity = UserIdentity.DeserializeUserIdentity(property.Value);
                    continue;
                }
                if (property.NameEquals("maxTaskRetryCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxTaskRetryCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("waitForSuccess"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    waitForSuccess = property.Value.GetBoolean();
                    continue;
                }
            }
            return new StartTask(commandLine, containerSettings.Value, Optional.ToList(resourceFiles), Optional.ToList(environmentSettings), userIdentity.Value, Optional.ToNullable(maxTaskRetryCount), Optional.ToNullable(waitForSuccess));
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static StartTask FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeStartTask(document.RootElement);
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
