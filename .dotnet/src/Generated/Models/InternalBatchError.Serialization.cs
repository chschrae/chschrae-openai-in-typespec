// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;

namespace OpenAI.Batch
{
    internal partial class InternalBatchError : IJsonModel<InternalBatchError>
    {
        void IJsonModel<InternalBatchError>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InternalBatchError>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalBatchError)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (SerializedAdditionalRawData?.ContainsKey("code") != true && Optional.IsDefined(Code))
            {
                writer.WritePropertyName("code"u8);
                writer.WriteStringValue(Code);
            }
            if (SerializedAdditionalRawData?.ContainsKey("message") != true && Optional.IsDefined(Message))
            {
                writer.WritePropertyName("message"u8);
                writer.WriteStringValue(Message);
            }
            if (SerializedAdditionalRawData?.ContainsKey("param") != true && Optional.IsDefined(Param))
            {
                if (Param != null)
                {
                    writer.WritePropertyName("param"u8);
                    writer.WriteStringValue(Param);
                }
                else
                {
                    writer.WriteNull("param");
                }
            }
            if (SerializedAdditionalRawData?.ContainsKey("line") != true && Optional.IsDefined(Line))
            {
                if (Line != null)
                {
                    writer.WritePropertyName("line"u8);
                    writer.WriteNumberValue(Line.Value);
                }
                else
                {
                    writer.WriteNull("line");
                }
            }
            if (SerializedAdditionalRawData != null)
            {
                foreach (var item in SerializedAdditionalRawData)
                {
                    if (ModelSerializationExtensions.IsSentinelValue(item.Value))
                    {
                        continue;
                    }
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

        InternalBatchError IJsonModel<InternalBatchError>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InternalBatchError>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalBatchError)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeInternalBatchError(document.RootElement, options);
        }

        internal static InternalBatchError DeserializeInternalBatchError(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string code = default;
            string message = default;
            string param = default;
            int? line = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("code"u8))
                {
                    code = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("message"u8))
                {
                    message = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("param"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        param = null;
                        continue;
                    }
                    param = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("line"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        line = null;
                        continue;
                    }
                    line = property.Value.GetInt32();
                    continue;
                }
                if (true)
                {
                    rawDataDictionary ??= new Dictionary<string, BinaryData>();
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new InternalBatchError(code, message, param, line, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<InternalBatchError>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InternalBatchError>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(InternalBatchError)} does not support writing '{options.Format}' format.");
            }
        }

        InternalBatchError IPersistableModel<InternalBatchError>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InternalBatchError>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeInternalBatchError(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(InternalBatchError)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<InternalBatchError>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        internal static InternalBatchError FromResponse(PipelineResponse response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeInternalBatchError(document.RootElement);
        }

        internal virtual BinaryContent ToBinaryContent()
        {
            return BinaryContent.Create(this, ModelSerializationExtensions.WireOptions);
        }
    }
}
