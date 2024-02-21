// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Migrate.Models
{
    public partial class MigrateAssessmentProjectPatch : IUtf8JsonSerializable, IJsonModel<MigrateAssessmentProjectPatch>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MigrateAssessmentProjectPatch>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MigrateAssessmentProjectPatch>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MigrateAssessmentProjectPatch>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MigrateAssessmentProjectPatch)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(AssessmentSolutionId))
            {
                writer.WritePropertyName("assessmentSolutionId"u8);
                writer.WriteStringValue(AssessmentSolutionId);
            }
            if (Optional.IsDefined(ProjectStatus))
            {
                writer.WritePropertyName("projectStatus"u8);
                writer.WriteStringValue(ProjectStatus.Value.ToString());
            }
            if (Optional.IsDefined(CustomerWorkspaceId))
            {
                writer.WritePropertyName("customerWorkspaceId"u8);
                writer.WriteStringValue(CustomerWorkspaceId);
            }
            if (Optional.IsDefined(CustomerWorkspaceLocation))
            {
                writer.WritePropertyName("customerWorkspaceLocation"u8);
                writer.WriteStringValue(CustomerWorkspaceLocation);
            }
            if (Optional.IsDefined(PublicNetworkAccess))
            {
                writer.WritePropertyName("publicNetworkAccess"u8);
                writer.WriteStringValue(PublicNetworkAccess);
            }
            if (Optional.IsDefined(CustomerStorageAccountArmId))
            {
                writer.WritePropertyName("customerStorageAccountArmId"u8);
                writer.WriteStringValue(CustomerStorageAccountArmId);
            }
            if (Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            writer.WriteEndObject();
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        MigrateAssessmentProjectPatch IJsonModel<MigrateAssessmentProjectPatch>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MigrateAssessmentProjectPatch>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MigrateAssessmentProjectPatch)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMigrateAssessmentProjectPatch(document.RootElement, options);
        }

        internal static MigrateAssessmentProjectPatch DeserializeMigrateAssessmentProjectPatch(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IDictionary<string, string>> tags = default;
            Optional<string> assessmentSolutionId = default;
            Optional<AssessmentProjectStatus> projectStatus = default;
            Optional<ResourceIdentifier> customerWorkspaceId = default;
            Optional<string> customerWorkspaceLocation = default;
            Optional<string> publicNetworkAccess = default;
            Optional<ResourceIdentifier> customerStorageAccountArmId = default;
            Optional<MigrateProvisioningState> provisioningState = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("assessmentSolutionId"u8))
                        {
                            assessmentSolutionId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("projectStatus"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            projectStatus = new AssessmentProjectStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("customerWorkspaceId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            customerWorkspaceId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("customerWorkspaceLocation"u8))
                        {
                            customerWorkspaceLocation = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("publicNetworkAccess"u8))
                        {
                            publicNetworkAccess = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("customerStorageAccountArmId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            customerStorageAccountArmId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new MigrateProvisioningState(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MigrateAssessmentProjectPatch(Optional.ToDictionary(tags), assessmentSolutionId.Value, Optional.ToNullable(projectStatus), customerWorkspaceId.Value, customerWorkspaceLocation.Value, publicNetworkAccess.Value, customerStorageAccountArmId.Value, Optional.ToNullable(provisioningState), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MigrateAssessmentProjectPatch>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MigrateAssessmentProjectPatch>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MigrateAssessmentProjectPatch)} does not support '{options.Format}' format.");
            }
        }

        MigrateAssessmentProjectPatch IPersistableModel<MigrateAssessmentProjectPatch>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MigrateAssessmentProjectPatch>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMigrateAssessmentProjectPatch(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MigrateAssessmentProjectPatch)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MigrateAssessmentProjectPatch>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
