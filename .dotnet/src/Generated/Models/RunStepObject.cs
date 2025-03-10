// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.Internal.Models
{
    /// <summary> Represents a step in execution of a run. </summary>
    internal partial class RunStepObject
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="RunStepObject"/>. </summary>
        /// <param name="id"> The identifier of the run step, which can be referenced in API endpoints. </param>
        /// <param name="createdAt"> The Unix timestamp (in seconds) for when the run step was created. </param>
        /// <param name="assistantId"> The ID of the [assistant](/docs/api-reference/assistants) associated with the run step. </param>
        /// <param name="threadId"> The ID of the [thread](/docs/api-reference/threads) that was run. </param>
        /// <param name="runId"> The ID of the [run](/docs/api-reference/runs) that this run step is a part of. </param>
        /// <param name="type"> The type of run step, which can be either `message_creation` or `tool_calls`. </param>
        /// <param name="status">
        /// The status of the run step, which can be either `in_progress`, `cancelled`, `failed`,
        /// `completed`, or `expired`.
        /// </param>
        /// <param name="stepDetails"> The details of the run step. </param>
        /// <param name="lastError"> The last error associated with this run step. Will be `null` if there are no errors. </param>
        /// <param name="expiresAt">
        /// The Unix timestamp (in seconds) for when the run step expired. A step is considered expired
        /// if the parent run is expired.
        /// </param>
        /// <param name="cancelledAt"> The Unix timestamp (in seconds) for when the run step was cancelled. </param>
        /// <param name="failedAt"> The Unix timestamp (in seconds) for when the run step failed. </param>
        /// <param name="completedAt"> T The Unix timestamp (in seconds) for when the run step completed.. </param>
        /// <param name="metadata">
        /// Set of 16 key-value pairs that can be attached to an object. This can be useful for storing
        /// additional information about the object in a structured format. Keys can be a maximum of 64
        /// characters long and values can be a maxium of 512 characters long.
        /// </param>
        /// <param name="usage"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/>, <paramref name="assistantId"/>, <paramref name="threadId"/>, <paramref name="runId"/> or <paramref name="stepDetails"/> is null. </exception>
        internal RunStepObject(string id, DateTimeOffset createdAt, string assistantId, string threadId, string runId, RunStepObjectType type, RunStepObjectStatus status, BinaryData stepDetails, RunStepObjectLastError lastError, DateTimeOffset? expiresAt, DateTimeOffset? cancelledAt, DateTimeOffset? failedAt, DateTimeOffset? completedAt, IReadOnlyDictionary<string, string> metadata, RunCompletionUsage usage)
        {
            Argument.AssertNotNull(id, nameof(id));
            Argument.AssertNotNull(assistantId, nameof(assistantId));
            Argument.AssertNotNull(threadId, nameof(threadId));
            Argument.AssertNotNull(runId, nameof(runId));
            Argument.AssertNotNull(stepDetails, nameof(stepDetails));

            Id = id;
            CreatedAt = createdAt;
            AssistantId = assistantId;
            ThreadId = threadId;
            RunId = runId;
            Type = type;
            Status = status;
            StepDetails = stepDetails;
            LastError = lastError;
            ExpiresAt = expiresAt;
            CancelledAt = cancelledAt;
            FailedAt = failedAt;
            CompletedAt = completedAt;
            Metadata = metadata;
            Usage = usage;
        }

        /// <summary> Initializes a new instance of <see cref="RunStepObject"/>. </summary>
        /// <param name="id"> The identifier of the run step, which can be referenced in API endpoints. </param>
        /// <param name="object"> The object type, which is always `thread.run.step`. </param>
        /// <param name="createdAt"> The Unix timestamp (in seconds) for when the run step was created. </param>
        /// <param name="assistantId"> The ID of the [assistant](/docs/api-reference/assistants) associated with the run step. </param>
        /// <param name="threadId"> The ID of the [thread](/docs/api-reference/threads) that was run. </param>
        /// <param name="runId"> The ID of the [run](/docs/api-reference/runs) that this run step is a part of. </param>
        /// <param name="type"> The type of run step, which can be either `message_creation` or `tool_calls`. </param>
        /// <param name="status">
        /// The status of the run step, which can be either `in_progress`, `cancelled`, `failed`,
        /// `completed`, or `expired`.
        /// </param>
        /// <param name="stepDetails"> The details of the run step. </param>
        /// <param name="lastError"> The last error associated with this run step. Will be `null` if there are no errors. </param>
        /// <param name="expiresAt">
        /// The Unix timestamp (in seconds) for when the run step expired. A step is considered expired
        /// if the parent run is expired.
        /// </param>
        /// <param name="cancelledAt"> The Unix timestamp (in seconds) for when the run step was cancelled. </param>
        /// <param name="failedAt"> The Unix timestamp (in seconds) for when the run step failed. </param>
        /// <param name="completedAt"> T The Unix timestamp (in seconds) for when the run step completed.. </param>
        /// <param name="metadata">
        /// Set of 16 key-value pairs that can be attached to an object. This can be useful for storing
        /// additional information about the object in a structured format. Keys can be a maximum of 64
        /// characters long and values can be a maxium of 512 characters long.
        /// </param>
        /// <param name="usage"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal RunStepObject(string id, RunStepObjectObject @object, DateTimeOffset createdAt, string assistantId, string threadId, string runId, RunStepObjectType type, RunStepObjectStatus status, BinaryData stepDetails, RunStepObjectLastError lastError, DateTimeOffset? expiresAt, DateTimeOffset? cancelledAt, DateTimeOffset? failedAt, DateTimeOffset? completedAt, IReadOnlyDictionary<string, string> metadata, RunCompletionUsage usage, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Id = id;
            Object = @object;
            CreatedAt = createdAt;
            AssistantId = assistantId;
            ThreadId = threadId;
            RunId = runId;
            Type = type;
            Status = status;
            StepDetails = stepDetails;
            LastError = lastError;
            ExpiresAt = expiresAt;
            CancelledAt = cancelledAt;
            FailedAt = failedAt;
            CompletedAt = completedAt;
            Metadata = metadata;
            Usage = usage;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="RunStepObject"/> for deserialization. </summary>
        internal RunStepObject()
        {
        }

        /// <summary> The identifier of the run step, which can be referenced in API endpoints. </summary>
        public string Id { get; }
        /// <summary> The object type, which is always `thread.run.step`. </summary>
        public RunStepObjectObject Object { get; } = RunStepObjectObject.ThreadRunStep;

        /// <summary> The Unix timestamp (in seconds) for when the run step was created. </summary>
        public DateTimeOffset CreatedAt { get; }
        /// <summary> The ID of the [assistant](/docs/api-reference/assistants) associated with the run step. </summary>
        public string AssistantId { get; }
        /// <summary> The ID of the [thread](/docs/api-reference/threads) that was run. </summary>
        public string ThreadId { get; }
        /// <summary> The ID of the [run](/docs/api-reference/runs) that this run step is a part of. </summary>
        public string RunId { get; }
        /// <summary> The type of run step, which can be either `message_creation` or `tool_calls`. </summary>
        public RunStepObjectType Type { get; }
        /// <summary>
        /// The status of the run step, which can be either `in_progress`, `cancelled`, `failed`,
        /// `completed`, or `expired`.
        /// </summary>
        public RunStepObjectStatus Status { get; }
        /// <summary>
        /// The details of the run step.
        /// <para>
        /// To assign an object to this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// <remarks>
        /// Supported types:
        /// <list type="bullet">
        /// <item>
        /// <description><see cref="RunStepDetailsMessageCreationObject"/></description>
        /// </item>
        /// <item>
        /// <description><see cref="RunStepDetailsToolCallsObject"/></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        public BinaryData StepDetails { get; }
        /// <summary> The last error associated with this run step. Will be `null` if there are no errors. </summary>
        public RunStepObjectLastError LastError { get; }
        /// <summary>
        /// The Unix timestamp (in seconds) for when the run step expired. A step is considered expired
        /// if the parent run is expired.
        /// </summary>
        public DateTimeOffset? ExpiresAt { get; }
        /// <summary> The Unix timestamp (in seconds) for when the run step was cancelled. </summary>
        public DateTimeOffset? CancelledAt { get; }
        /// <summary> The Unix timestamp (in seconds) for when the run step failed. </summary>
        public DateTimeOffset? FailedAt { get; }
        /// <summary> T The Unix timestamp (in seconds) for when the run step completed.. </summary>
        public DateTimeOffset? CompletedAt { get; }
        /// <summary>
        /// Set of 16 key-value pairs that can be attached to an object. This can be useful for storing
        /// additional information about the object in a structured format. Keys can be a maximum of 64
        /// characters long and values can be a maxium of 512 characters long.
        /// </summary>
        public IReadOnlyDictionary<string, string> Metadata { get; }
        /// <summary> Gets the usage. </summary>
        public RunCompletionUsage Usage { get; }
    }
}
