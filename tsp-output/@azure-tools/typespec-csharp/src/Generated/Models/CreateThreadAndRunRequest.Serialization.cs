// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;

namespace OpenAI.Models
{
    public partial class CreateThreadAndRunRequest : IJsonModel<CreateThreadAndRunRequest>
    {
        void IJsonModel<CreateThreadAndRunRequest>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CreateThreadAndRunRequest>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CreateThreadAndRunRequest)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("assistant_id"u8);
            writer.WriteStringValue(AssistantId);
            if (Optional.IsDefined(Thread))
            {
                writer.WritePropertyName("thread"u8);
                writer.WriteObjectValue<CreateThreadRequest>(Thread, options);
            }
            if (Optional.IsDefined(Model))
            {
                if (Model != null)
                {
                    writer.WritePropertyName("model"u8);
                    writer.WriteStringValue(Model);
                }
                else
                {
                    writer.WriteNull("model");
                }
            }
            if (Optional.IsDefined(Instructions))
            {
                if (Instructions != null)
                {
                    writer.WritePropertyName("instructions"u8);
                    writer.WriteStringValue(Instructions);
                }
                else
                {
                    writer.WriteNull("instructions");
                }
            }
            if (Optional.IsCollectionDefined(Tools))
            {
                if (Tools != null)
                {
                    writer.WritePropertyName("tools"u8);
                    writer.WriteStartArray();
                    foreach (var item in Tools)
                    {
                        if (item == null)
                        {
                            writer.WriteNullValue();
                            continue;
                        }
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item);
#else
                        using (JsonDocument document = JsonDocument.Parse(item))
                        {
                            JsonSerializer.Serialize(writer, document.RootElement);
                        }
#endif
                    }
                    writer.WriteEndArray();
                }
                else
                {
                    writer.WriteNull("tools");
                }
            }
            if (Optional.IsCollectionDefined(Metadata))
            {
                if (Metadata != null)
                {
                    writer.WritePropertyName("metadata"u8);
                    writer.WriteStartObject();
                    foreach (var item in Metadata)
                    {
                        writer.WritePropertyName(item.Key);
                        writer.WriteStringValue(item.Value);
                    }
                    writer.WriteEndObject();
                }
                else
                {
                    writer.WriteNull("metadata");
                }
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

        CreateThreadAndRunRequest IJsonModel<CreateThreadAndRunRequest>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CreateThreadAndRunRequest>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CreateThreadAndRunRequest)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCreateThreadAndRunRequest(document.RootElement, options);
        }

        internal static CreateThreadAndRunRequest DeserializeCreateThreadAndRunRequest(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string assistantId = default;
            CreateThreadRequest thread = default;
            string model = default;
            string instructions = default;
            IList<BinaryData> tools = default;
            IDictionary<string, string> metadata = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("assistant_id"u8))
                {
                    assistantId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("thread"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    thread = CreateThreadRequest.DeserializeCreateThreadRequest(property.Value, options);
                    continue;
                }
                if (property.NameEquals("model"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        model = null;
                        continue;
                    }
                    model = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("instructions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        instructions = null;
                        continue;
                    }
                    instructions = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tools"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<BinaryData> array = new List<BinaryData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(BinaryData.FromString(item.GetRawText()));
                        }
                    }
                    tools = array;
                    continue;
                }
                if (property.NameEquals("metadata"u8))
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
                    metadata = dictionary;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new CreateThreadAndRunRequest(
                assistantId,
                thread,
                model,
                instructions,
                tools ?? new ChangeTrackingList<BinaryData>(),
                metadata ?? new ChangeTrackingDictionary<string, string>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<CreateThreadAndRunRequest>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CreateThreadAndRunRequest>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(CreateThreadAndRunRequest)} does not support writing '{options.Format}' format.");
            }
        }

        CreateThreadAndRunRequest IPersistableModel<CreateThreadAndRunRequest>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CreateThreadAndRunRequest>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeCreateThreadAndRunRequest(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CreateThreadAndRunRequest)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<CreateThreadAndRunRequest>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The result to deserialize the model from. </param>
        internal static CreateThreadAndRunRequest FromResponse(PipelineResponse response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeCreateThreadAndRunRequest(document.RootElement);
        }

        /// <summary> Convert into a Utf8JsonRequestBody. </summary>
        internal virtual BinaryContent ToBinaryBody()
        {
            return BinaryContent.Create(this, new ModelReaderWriterOptions("W"));
        }
    }
}
