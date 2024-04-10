// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;

namespace OpenAI.Internal.Models
{
    internal partial class RunStepObject : IJsonModel<RunStepObject>
    {
        void IJsonModel<RunStepObject>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RunStepObject>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RunStepObject)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("id"u8);
            writer.WriteStringValue(Id);
            writer.WritePropertyName("object"u8);
            writer.WriteStringValue(Object.ToString());
            writer.WritePropertyName("created_at"u8);
            writer.WriteNumberValue(CreatedAt, "U");
            writer.WritePropertyName("assistant_id"u8);
            writer.WriteStringValue(AssistantId);
            writer.WritePropertyName("thread_id"u8);
            writer.WriteStringValue(ThreadId);
            writer.WritePropertyName("run_id"u8);
            writer.WriteStringValue(RunId);
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(Type.ToString());
            writer.WritePropertyName("status"u8);
            writer.WriteStringValue(Status.ToString());
            writer.WritePropertyName("step_details"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(StepDetails);
#else
            using (JsonDocument document = JsonDocument.Parse(StepDetails))
            {
                JsonSerializer.Serialize(writer, document.RootElement);
            }
#endif
            if (LastError != null)
            {
                writer.WritePropertyName("last_error"u8);
                writer.WriteObjectValue<RunStepObjectLastError>(LastError, options);
            }
            else
            {
                writer.WriteNull("last_error");
            }
            if (ExpiresAt != null)
            {
                writer.WritePropertyName("expires_at"u8);
                writer.WriteStringValue(ExpiresAt.Value, "O");
            }
            else
            {
                writer.WriteNull("expires_at");
            }
            if (CancelledAt != null)
            {
                writer.WritePropertyName("cancelled_at"u8);
                writer.WriteStringValue(CancelledAt.Value, "O");
            }
            else
            {
                writer.WriteNull("cancelled_at");
            }
            if (FailedAt != null)
            {
                writer.WritePropertyName("failed_at"u8);
                writer.WriteStringValue(FailedAt.Value, "O");
            }
            else
            {
                writer.WriteNull("failed_at");
            }
            if (CompletedAt != null)
            {
                writer.WritePropertyName("completed_at"u8);
                writer.WriteStringValue(CompletedAt.Value, "O");
            }
            else
            {
                writer.WriteNull("completed_at");
            }
            if (Metadata != null && Optional.IsCollectionDefined(Metadata))
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
            if (Usage != null)
            {
                writer.WritePropertyName("usage"u8);
                writer.WriteObjectValue<RunStepCompletionUsage>(Usage, options);
            }
            else
            {
                writer.WriteNull("usage");
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

        RunStepObject IJsonModel<RunStepObject>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RunStepObject>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RunStepObject)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRunStepObject(document.RootElement, options);
        }

        internal static RunStepObject DeserializeRunStepObject(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string id = default;
            RunStepObjectObject @object = default;
            DateTimeOffset createdAt = default;
            string assistantId = default;
            string threadId = default;
            string runId = default;
            RunStepObjectType type = default;
            RunStepObjectStatus status = default;
            BinaryData stepDetails = default;
            RunStepObjectLastError lastError = default;
            DateTimeOffset? expiresAt = default;
            DateTimeOffset? cancelledAt = default;
            DateTimeOffset? failedAt = default;
            DateTimeOffset? completedAt = default;
            IReadOnlyDictionary<string, string> metadata = default;
            RunStepCompletionUsage usage = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("object"u8))
                {
                    @object = new RunStepObjectObject(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("created_at"u8))
                {
                    createdAt = DateTimeOffset.FromUnixTimeSeconds(property.Value.GetInt64());
                    continue;
                }
                if (property.NameEquals("assistant_id"u8))
                {
                    assistantId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("thread_id"u8))
                {
                    threadId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("run_id"u8))
                {
                    runId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new RunStepObjectType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    status = new RunStepObjectStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("step_details"u8))
                {
                    stepDetails = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("last_error"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        lastError = null;
                        continue;
                    }
                    lastError = RunStepObjectLastError.DeserializeRunStepObjectLastError(property.Value, options);
                    continue;
                }
                if (property.NameEquals("expires_at"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        expiresAt = null;
                        continue;
                    }
                    expiresAt = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("cancelled_at"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        cancelledAt = null;
                        continue;
                    }
                    cancelledAt = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("failed_at"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        failedAt = null;
                        continue;
                    }
                    failedAt = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("completed_at"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        completedAt = null;
                        continue;
                    }
                    completedAt = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("metadata"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        metadata = new ChangeTrackingDictionary<string, string>();
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
                if (property.NameEquals("usage"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        usage = null;
                        continue;
                    }
                    usage = RunStepCompletionUsage.DeserializeRunStepCompletionUsage(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new RunStepObject(
                id,
                @object,
                createdAt,
                assistantId,
                threadId,
                runId,
                type,
                status,
                stepDetails,
                lastError,
                expiresAt,
                cancelledAt,
                failedAt,
                completedAt,
                metadata,
                usage,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<RunStepObject>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RunStepObject>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(RunStepObject)} does not support writing '{options.Format}' format.");
            }
        }

        RunStepObject IPersistableModel<RunStepObject>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RunStepObject>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeRunStepObject(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(RunStepObject)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<RunStepObject>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The result to deserialize the model from. </param>
        internal static RunStepObject FromResponse(PipelineResponse response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeRunStepObject(document.RootElement);
        }

        /// <summary> Convert into a Utf8JsonRequestBody. </summary>
        internal virtual BinaryContent ToBinaryBody()
        {
            return BinaryContent.Create(this, new ModelReaderWriterOptions("W"));
        }
    }
}
