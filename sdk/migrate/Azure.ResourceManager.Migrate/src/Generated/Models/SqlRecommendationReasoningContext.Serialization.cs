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
    public partial class SqlRecommendationReasoningContext : IUtf8JsonSerializable, IJsonModel<SqlRecommendationReasoningContext>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SqlRecommendationReasoningContext>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SqlRecommendationReasoningContext>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SqlRecommendationReasoningContext>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SqlRecommendationReasoningContext)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(ContextKey))
            {
                writer.WritePropertyName("contextKey"u8);
                writer.WriteStringValue(ContextKey);
            }
            if (Optional.IsDefined(ContextValue))
            {
                writer.WritePropertyName("contextValue"u8);
                writer.WriteStringValue(ContextValue);
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

        SqlRecommendationReasoningContext IJsonModel<SqlRecommendationReasoningContext>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SqlRecommendationReasoningContext>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SqlRecommendationReasoningContext)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSqlRecommendationReasoningContext(document.RootElement, options);
        }

        internal static SqlRecommendationReasoningContext DeserializeSqlRecommendationReasoningContext(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> contextKey = default;
            Optional<string> contextValue = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("contextKey"u8))
                {
                    contextKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("contextValue"u8))
                {
                    contextValue = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SqlRecommendationReasoningContext(contextKey.Value, contextValue.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SqlRecommendationReasoningContext>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SqlRecommendationReasoningContext>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SqlRecommendationReasoningContext)} does not support '{options.Format}' format.");
            }
        }

        SqlRecommendationReasoningContext IPersistableModel<SqlRecommendationReasoningContext>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SqlRecommendationReasoningContext>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSqlRecommendationReasoningContext(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SqlRecommendationReasoningContext)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SqlRecommendationReasoningContext>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
