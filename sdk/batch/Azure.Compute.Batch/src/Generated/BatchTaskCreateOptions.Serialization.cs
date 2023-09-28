// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Compute.Batch
{
    public partial class BatchTaskCreateOptions : IUtf8JsonSerializable
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
            if (Optional.IsDefined(ExitConditions))
            {
                writer.WritePropertyName("exitConditions"u8);
                writer.WriteObjectValue(ExitConditions);
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
            if (Optional.IsDefined(AffinityInfo))
            {
                writer.WritePropertyName("affinityInfo"u8);
                writer.WriteObjectValue(AffinityInfo);
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
            if (Optional.IsDefined(UserIdentity))
            {
                writer.WritePropertyName("userIdentity"u8);
                writer.WriteObjectValue(UserIdentity);
            }
            if (Optional.IsDefined(MultiInstanceSettings))
            {
                writer.WritePropertyName("multiInstanceSettings"u8);
                writer.WriteObjectValue(MultiInstanceSettings);
            }
            if (Optional.IsDefined(DependsOn))
            {
                writer.WritePropertyName("dependsOn"u8);
                writer.WriteObjectValue(DependsOn);
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
            writer.WriteEndObject();
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
