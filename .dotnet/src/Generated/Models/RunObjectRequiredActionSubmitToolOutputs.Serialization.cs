// <auto-generated/>

using System;
using OpenAI.ClientShared.Internal;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using OpenAI;

namespace OpenAI.Internal.Models
{
    internal partial class RunObjectRequiredActionSubmitToolOutputs : IJsonModel<RunObjectRequiredActionSubmitToolOutputs>
    {
        void IJsonModel<RunObjectRequiredActionSubmitToolOutputs>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RunObjectRequiredActionSubmitToolOutputs>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RunObjectRequiredActionSubmitToolOutputs)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("tool_calls"u8);
            writer.WriteStartArray();
            foreach (var item in ToolCalls)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
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

        RunObjectRequiredActionSubmitToolOutputs IJsonModel<RunObjectRequiredActionSubmitToolOutputs>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RunObjectRequiredActionSubmitToolOutputs>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RunObjectRequiredActionSubmitToolOutputs)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRunObjectRequiredActionSubmitToolOutputs(document.RootElement, options);
        }

        internal static RunObjectRequiredActionSubmitToolOutputs DeserializeRunObjectRequiredActionSubmitToolOutputs(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<RunToolCallObject> toolCalls = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tool_calls"u8))
                {
                    List<RunToolCallObject> array = new List<RunToolCallObject>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(RunToolCallObject.DeserializeRunToolCallObject(item, options));
                    }
                    toolCalls = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new RunObjectRequiredActionSubmitToolOutputs(toolCalls, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<RunObjectRequiredActionSubmitToolOutputs>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RunObjectRequiredActionSubmitToolOutputs>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(RunObjectRequiredActionSubmitToolOutputs)} does not support '{options.Format}' format.");
            }
        }

        RunObjectRequiredActionSubmitToolOutputs IPersistableModel<RunObjectRequiredActionSubmitToolOutputs>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RunObjectRequiredActionSubmitToolOutputs>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeRunObjectRequiredActionSubmitToolOutputs(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(RunObjectRequiredActionSubmitToolOutputs)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<RunObjectRequiredActionSubmitToolOutputs>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The result to deserialize the model from. </param>
        internal static RunObjectRequiredActionSubmitToolOutputs FromResponse(PipelineResponse response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeRunObjectRequiredActionSubmitToolOutputs(document.RootElement);
        }

        /// <summary> Convert into a Utf8JsonRequestBody. </summary>
        internal virtual BinaryContent ToRequestBody()
        {
            var content = new Utf8JsonRequestBody();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }
    }
}
