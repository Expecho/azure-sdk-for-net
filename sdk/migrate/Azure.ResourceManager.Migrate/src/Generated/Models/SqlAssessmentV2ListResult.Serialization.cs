// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Migrate;

namespace Azure.ResourceManager.Migrate.Models
{
    internal partial class SqlAssessmentV2ListResult : IUtf8JsonSerializable, IJsonModel<SqlAssessmentV2ListResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SqlAssessmentV2ListResult>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SqlAssessmentV2ListResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SqlAssessmentV2ListResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SqlAssessmentV2ListResult)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("value"u8);
            writer.WriteStartArray();
            foreach (var item in Value)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            if (Optional.IsDefined(NextLink))
            {
                writer.WritePropertyName("nextLink"u8);
                writer.WriteStringValue(NextLink.AbsoluteUri);
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

        SqlAssessmentV2ListResult IJsonModel<SqlAssessmentV2ListResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SqlAssessmentV2ListResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SqlAssessmentV2ListResult)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSqlAssessmentV2ListResult(document.RootElement, options);
        }

        internal static SqlAssessmentV2ListResult DeserializeSqlAssessmentV2ListResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<MigrateSqlAssessmentV2Data> value = default;
            Optional<Uri> nextLink = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    List<MigrateSqlAssessmentV2Data> array = new List<MigrateSqlAssessmentV2Data>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MigrateSqlAssessmentV2Data.DeserializeMigrateSqlAssessmentV2Data(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    nextLink = new Uri(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SqlAssessmentV2ListResult(value, nextLink.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SqlAssessmentV2ListResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SqlAssessmentV2ListResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SqlAssessmentV2ListResult)} does not support '{options.Format}' format.");
            }
        }

        SqlAssessmentV2ListResult IPersistableModel<SqlAssessmentV2ListResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SqlAssessmentV2ListResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSqlAssessmentV2ListResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SqlAssessmentV2ListResult)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SqlAssessmentV2ListResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
