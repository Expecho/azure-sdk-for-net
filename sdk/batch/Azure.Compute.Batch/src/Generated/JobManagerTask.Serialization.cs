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
    public partial class JobManagerTask : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("id"u8);
            writer.WriteStringValue(Id);
            if (Optional.IsDefined(DisplayName))
            {
                writer.WritePropertyName("displayName"u8);
                writer.WriteStringValue(DisplayName);
            }
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
            if (Optional.IsCollectionDefined(OutputFiles))
            {
                writer.WritePropertyName("outputFiles"u8);
                writer.WriteStartArray();
                foreach (var item in OutputFiles)
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
            if (Optional.IsDefined(Constraints))
            {
                writer.WritePropertyName("constraints"u8);
                writer.WriteObjectValue(Constraints);
            }
            if (Optional.IsDefined(RequiredSlots))
            {
                writer.WritePropertyName("requiredSlots"u8);
                writer.WriteNumberValue(RequiredSlots.Value);
            }
            if (Optional.IsDefined(KillJobOnCompletion))
            {
                writer.WritePropertyName("killJobOnCompletion"u8);
                writer.WriteBooleanValue(KillJobOnCompletion.Value);
            }
            if (Optional.IsDefined(UserIdentity))
            {
                writer.WritePropertyName("userIdentity"u8);
                writer.WriteObjectValue(UserIdentity);
            }
            if (Optional.IsDefined(RunExclusive))
            {
                writer.WritePropertyName("runExclusive"u8);
                writer.WriteBooleanValue(RunExclusive.Value);
            }
            if (Optional.IsCollectionDefined(ApplicationPackageReferences))
            {
                writer.WritePropertyName("applicationPackageReferences"u8);
                writer.WriteStartArray();
                foreach (var item in ApplicationPackageReferences)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(AuthenticationTokenSettings))
            {
                writer.WritePropertyName("authenticationTokenSettings"u8);
                writer.WriteObjectValue(AuthenticationTokenSettings);
            }
            if (Optional.IsDefined(AllowLowPriorityNode))
            {
                writer.WritePropertyName("allowLowPriorityNode"u8);
                writer.WriteBooleanValue(AllowLowPriorityNode.Value);
            }
            writer.WriteEndObject();
        }

        internal static JobManagerTask DeserializeJobManagerTask(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string id = default;
            Optional<string> displayName = default;
            string commandLine = default;
            Optional<TaskContainerSettings> containerSettings = default;
            Optional<IList<ResourceFile>> resourceFiles = default;
            Optional<IList<OutputFile>> outputFiles = default;
            Optional<IList<EnvironmentSetting>> environmentSettings = default;
            Optional<TaskConstraints> constraints = default;
            Optional<int> requiredSlots = default;
            Optional<bool> killJobOnCompletion = default;
            Optional<UserIdentity> userIdentity = default;
            Optional<bool> runExclusive = default;
            Optional<IList<ApplicationPackageReference>> applicationPackageReferences = default;
            Optional<AuthenticationTokenSettings> authenticationTokenSettings = default;
            Optional<bool> allowLowPriorityNode = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("displayName"u8))
                {
                    displayName = property.Value.GetString();
                    continue;
                }
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
                if (property.NameEquals("outputFiles"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<OutputFile> array = new List<OutputFile>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(OutputFile.DeserializeOutputFile(item));
                    }
                    outputFiles = array;
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
                if (property.NameEquals("constraints"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    constraints = TaskConstraints.DeserializeTaskConstraints(property.Value);
                    continue;
                }
                if (property.NameEquals("requiredSlots"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    requiredSlots = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("killJobOnCompletion"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    killJobOnCompletion = property.Value.GetBoolean();
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
                if (property.NameEquals("runExclusive"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    runExclusive = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("applicationPackageReferences"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ApplicationPackageReference> array = new List<ApplicationPackageReference>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ApplicationPackageReference.DeserializeApplicationPackageReference(item));
                    }
                    applicationPackageReferences = array;
                    continue;
                }
                if (property.NameEquals("authenticationTokenSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    authenticationTokenSettings = AuthenticationTokenSettings.DeserializeAuthenticationTokenSettings(property.Value);
                    continue;
                }
                if (property.NameEquals("allowLowPriorityNode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    allowLowPriorityNode = property.Value.GetBoolean();
                    continue;
                }
            }
            return new JobManagerTask(id, displayName.Value, commandLine, containerSettings.Value, Optional.ToList(resourceFiles), Optional.ToList(outputFiles), Optional.ToList(environmentSettings), constraints.Value, Optional.ToNullable(requiredSlots), Optional.ToNullable(killJobOnCompletion), userIdentity.Value, Optional.ToNullable(runExclusive), Optional.ToList(applicationPackageReferences), authenticationTokenSettings.Value, Optional.ToNullable(allowLowPriorityNode));
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static JobManagerTask FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeJobManagerTask(document.RootElement);
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
