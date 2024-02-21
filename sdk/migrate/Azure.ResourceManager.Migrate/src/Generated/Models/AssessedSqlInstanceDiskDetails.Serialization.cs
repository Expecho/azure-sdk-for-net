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
    public partial class AssessedSqlInstanceDiskDetails : IUtf8JsonSerializable, IJsonModel<AssessedSqlInstanceDiskDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AssessedSqlInstanceDiskDetails>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AssessedSqlInstanceDiskDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AssessedSqlInstanceDiskDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AssessedSqlInstanceDiskDetails)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(DiskId))
            {
                writer.WritePropertyName("diskId"u8);
                writer.WriteStringValue(DiskId);
            }
            if (Optional.IsDefined(DiskSizeInMB))
            {
                writer.WritePropertyName("diskSizeInMB"u8);
                writer.WriteNumberValue(DiskSizeInMB.Value);
            }
            if (Optional.IsDefined(MegabytesPerSecondOfRead))
            {
                writer.WritePropertyName("megabytesPerSecondOfRead"u8);
                writer.WriteNumberValue(MegabytesPerSecondOfRead.Value);
            }
            if (Optional.IsDefined(MegabytesPerSecondOfWrite))
            {
                writer.WritePropertyName("megabytesPerSecondOfWrite"u8);
                writer.WriteNumberValue(MegabytesPerSecondOfWrite.Value);
            }
            if (Optional.IsDefined(NumberOfReadOperationsPerSecond))
            {
                writer.WritePropertyName("numberOfReadOperationsPerSecond"u8);
                writer.WriteNumberValue(NumberOfReadOperationsPerSecond.Value);
            }
            if (Optional.IsDefined(NumberOfWriteOperationsPerSecond))
            {
                writer.WritePropertyName("numberOfWriteOperationsPerSecond"u8);
                writer.WriteNumberValue(NumberOfWriteOperationsPerSecond.Value);
            }
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

        AssessedSqlInstanceDiskDetails IJsonModel<AssessedSqlInstanceDiskDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AssessedSqlInstanceDiskDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AssessedSqlInstanceDiskDetails)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAssessedSqlInstanceDiskDetails(document.RootElement, options);
        }

        internal static AssessedSqlInstanceDiskDetails DeserializeAssessedSqlInstanceDiskDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> diskId = default;
            Optional<double> diskSizeInMB = default;
            Optional<double> megabytesPerSecondOfRead = default;
            Optional<double> megabytesPerSecondOfWrite = default;
            Optional<double> numberOfReadOperationsPerSecond = default;
            Optional<double> numberOfWriteOperationsPerSecond = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("diskId"u8))
                {
                    diskId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("diskSizeInMB"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    diskSizeInMB = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("megabytesPerSecondOfRead"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    megabytesPerSecondOfRead = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("megabytesPerSecondOfWrite"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    megabytesPerSecondOfWrite = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("numberOfReadOperationsPerSecond"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    numberOfReadOperationsPerSecond = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("numberOfWriteOperationsPerSecond"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    numberOfWriteOperationsPerSecond = property.Value.GetDouble();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AssessedSqlInstanceDiskDetails(diskId.Value, Optional.ToNullable(diskSizeInMB), Optional.ToNullable(megabytesPerSecondOfRead), Optional.ToNullable(megabytesPerSecondOfWrite), Optional.ToNullable(numberOfReadOperationsPerSecond), Optional.ToNullable(numberOfWriteOperationsPerSecond), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AssessedSqlInstanceDiskDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AssessedSqlInstanceDiskDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AssessedSqlInstanceDiskDetails)} does not support '{options.Format}' format.");
            }
        }

        AssessedSqlInstanceDiskDetails IPersistableModel<AssessedSqlInstanceDiskDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AssessedSqlInstanceDiskDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAssessedSqlInstanceDiskDetails(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AssessedSqlInstanceDiskDetails)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AssessedSqlInstanceDiskDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
