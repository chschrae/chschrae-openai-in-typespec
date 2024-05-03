// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;

namespace OpenAI.Images
{
    public partial class GeneratedImageCollection : IJsonModel<GeneratedImageCollection>
    {
        GeneratedImageCollection IJsonModel<GeneratedImageCollection>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GeneratedImageCollection>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(GeneratedImageCollection)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeGeneratedImageCollection(document.RootElement, options);
        }

        internal static GeneratedImageCollection DeserializeGeneratedImageCollection(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DateTimeOffset created = default;
            IReadOnlyList<GeneratedImage> data = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("created"u8))
                {
                    created = DateTimeOffset.FromUnixTimeSeconds(property.Value.GetInt64());
                    continue;
                }
                if (property.NameEquals("data"u8))
                {
                    List<GeneratedImage> array = new List<GeneratedImage>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(GeneratedImage.DeserializeGeneratedImage(item, options));
                    }
                    data = array;
                    continue;
                }
            }
            return new GeneratedImageCollection(created, data);
        }

        BinaryData IPersistableModel<GeneratedImageCollection>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GeneratedImageCollection>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(GeneratedImageCollection)} does not support writing '{options.Format}' format.");
            }
        }

        GeneratedImageCollection IPersistableModel<GeneratedImageCollection>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GeneratedImageCollection>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeGeneratedImageCollection(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(GeneratedImageCollection)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<GeneratedImageCollection>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The result to deserialize the model from. </param>
        internal static GeneratedImageCollection FromResponse(PipelineResponse response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeGeneratedImageCollection(document.RootElement);
        }

        /// <summary> Convert into a <see cref="BinaryContent"/>. </summary>
        internal virtual BinaryContent ToBinaryContent()
        {
            return BinaryContent.Create(this, ModelSerializationExtensions.WireOptions);
        }
    }
}
