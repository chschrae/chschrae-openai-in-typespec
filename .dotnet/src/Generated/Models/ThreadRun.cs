// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using OpenAI.Models;

namespace OpenAI.Assistants
{
    /// <summary> Represents an execution run on a [thread](/docs/api-reference/threads). </summary>
    public partial class ThreadRun
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

        /// <summary> Initializes a new instance of <see cref="ThreadRun"/>. </summary>
        /// <param name="id"> The identifier, which can be referenced in API endpoints. </param>
        /// <param name="createdAt"> The Unix timestamp (in seconds) for when the run was created. </param>
        /// <param name="threadId"> The ID of the [thread](/docs/api-reference/threads) that was executed on as a part of this run. </param>
        /// <param name="assistantId"> The ID of the [assistant](/docs/api-reference/assistants) used for execution of this run. </param>
        /// <param name="status"> The status of the run, which can be either `queued`, `in_progress`, `requires_action`, `cancelling`, `cancelled`, `failed`, `completed`, `incomplete`, or `expired`. </param>
        /// <param name="internalRequiredAction"> Details on the action required to continue the run. Will be `null` if no action is required. </param>
        /// <param name="lastError"> The last error associated with this run. Will be `null` if there are no errors. </param>
        /// <param name="expiresAt"> The Unix timestamp (in seconds) for when the run will expire. </param>
        /// <param name="startedAt"> The Unix timestamp (in seconds) for when the run was started. </param>
        /// <param name="cancelledAt"> The Unix timestamp (in seconds) for when the run was cancelled. </param>
        /// <param name="failedAt"> The Unix timestamp (in seconds) for when the run failed. </param>
        /// <param name="completedAt"> The Unix timestamp (in seconds) for when the run was completed. </param>
        /// <param name="incompleteDetails"> Details on why the run is incomplete. Will be `null` if the run is not incomplete. </param>
        /// <param name="model"> The model that the [assistant](/docs/api-reference/assistants) used for this run. </param>
        /// <param name="instructions"> The instructions that the [assistant](/docs/api-reference/assistants) used for this run. </param>
        /// <param name="tools">
        /// The list of tools that the [assistant](/docs/api-reference/assistants) used for this run.
        /// Please note <see cref="ToolDefinition"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="CodeInterpreterToolDefinition"/>, <see cref="FileSearchToolDefinition"/> and <see cref="FunctionToolDefinition"/>.
        /// </param>
        /// <param name="metadata"> Set of 16 key-value pairs that can be attached to an object. This can be useful for storing additional information about the object in a structured format. Keys can be a maximum of 64 characters long and values can be a maxium of 512 characters long. </param>
        /// <param name="usage"></param>
        /// <param name="maxPromptTokens"> The maximum number of prompt tokens specified to have been used over the course of the run. </param>
        /// <param name="maxCompletionTokens"> The maximum number of completion tokens specified to have been used over the course of the run. </param>
        /// <param name="truncationStrategy"></param>
        /// <param name="toolConstraint"></param>
        /// <param name="responseFormat"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/>, <paramref name="threadId"/>, <paramref name="assistantId"/>, <paramref name="model"/>, <paramref name="instructions"/> or <paramref name="tools"/> is null. </exception>
        internal ThreadRun(string id, DateTimeOffset createdAt, string threadId, string assistantId, RunStatus status, InternalRunRequiredAction internalRequiredAction, RunError lastError, DateTimeOffset? expiresAt, DateTimeOffset? startedAt, DateTimeOffset? cancelledAt, DateTimeOffset? failedAt, DateTimeOffset? completedAt, RunIncompleteDetails incompleteDetails, string model, string instructions, IEnumerable<ToolDefinition> tools, IReadOnlyDictionary<string, string> metadata, RunTokenUsage usage, int? maxPromptTokens, int? maxCompletionTokens, RunTruncationStrategy truncationStrategy, ToolConstraint toolConstraint, AssistantResponseFormat responseFormat)
        {
            Argument.AssertNotNull(id, nameof(id));
            Argument.AssertNotNull(threadId, nameof(threadId));
            Argument.AssertNotNull(assistantId, nameof(assistantId));
            Argument.AssertNotNull(model, nameof(model));
            Argument.AssertNotNull(instructions, nameof(instructions));
            Argument.AssertNotNull(tools, nameof(tools));

            Id = id;
            CreatedAt = createdAt;
            ThreadId = threadId;
            AssistantId = assistantId;
            Status = status;
            _internalRequiredAction = internalRequiredAction;
            LastError = lastError;
            ExpiresAt = expiresAt;
            StartedAt = startedAt;
            CancelledAt = cancelledAt;
            FailedAt = failedAt;
            CompletedAt = completedAt;
            IncompleteDetails = incompleteDetails;
            Model = model;
            Instructions = instructions;
            Tools = tools.ToList();
            Metadata = metadata;
            Usage = usage;
            MaxPromptTokens = maxPromptTokens;
            MaxCompletionTokens = maxCompletionTokens;
            TruncationStrategy = truncationStrategy;
            ToolConstraint = toolConstraint;
            ResponseFormat = responseFormat;
        }

        /// <summary> Initializes a new instance of <see cref="ThreadRun"/>. </summary>
        /// <param name="id"> The identifier, which can be referenced in API endpoints. </param>
        /// <param name="object"> The object type, which is always `thread.run`. </param>
        /// <param name="createdAt"> The Unix timestamp (in seconds) for when the run was created. </param>
        /// <param name="threadId"> The ID of the [thread](/docs/api-reference/threads) that was executed on as a part of this run. </param>
        /// <param name="assistantId"> The ID of the [assistant](/docs/api-reference/assistants) used for execution of this run. </param>
        /// <param name="status"> The status of the run, which can be either `queued`, `in_progress`, `requires_action`, `cancelling`, `cancelled`, `failed`, `completed`, `incomplete`, or `expired`. </param>
        /// <param name="internalRequiredAction"> Details on the action required to continue the run. Will be `null` if no action is required. </param>
        /// <param name="lastError"> The last error associated with this run. Will be `null` if there are no errors. </param>
        /// <param name="expiresAt"> The Unix timestamp (in seconds) for when the run will expire. </param>
        /// <param name="startedAt"> The Unix timestamp (in seconds) for when the run was started. </param>
        /// <param name="cancelledAt"> The Unix timestamp (in seconds) for when the run was cancelled. </param>
        /// <param name="failedAt"> The Unix timestamp (in seconds) for when the run failed. </param>
        /// <param name="completedAt"> The Unix timestamp (in seconds) for when the run was completed. </param>
        /// <param name="incompleteDetails"> Details on why the run is incomplete. Will be `null` if the run is not incomplete. </param>
        /// <param name="model"> The model that the [assistant](/docs/api-reference/assistants) used for this run. </param>
        /// <param name="instructions"> The instructions that the [assistant](/docs/api-reference/assistants) used for this run. </param>
        /// <param name="tools">
        /// The list of tools that the [assistant](/docs/api-reference/assistants) used for this run.
        /// Please note <see cref="ToolDefinition"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="CodeInterpreterToolDefinition"/>, <see cref="FileSearchToolDefinition"/> and <see cref="FunctionToolDefinition"/>.
        /// </param>
        /// <param name="metadata"> Set of 16 key-value pairs that can be attached to an object. This can be useful for storing additional information about the object in a structured format. Keys can be a maximum of 64 characters long and values can be a maxium of 512 characters long. </param>
        /// <param name="usage"></param>
        /// <param name="temperature"> The sampling temperature used for this run. If not set, defaults to 1. </param>
        /// <param name="nucleusSamplingFactor"> The nucleus sampling value used for this run. If not set, defaults to 1. </param>
        /// <param name="maxPromptTokens"> The maximum number of prompt tokens specified to have been used over the course of the run. </param>
        /// <param name="maxCompletionTokens"> The maximum number of completion tokens specified to have been used over the course of the run. </param>
        /// <param name="truncationStrategy"></param>
        /// <param name="toolConstraint"></param>
        /// <param name="responseFormat"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ThreadRun(string id, object @object, DateTimeOffset createdAt, string threadId, string assistantId, RunStatus status, InternalRunRequiredAction internalRequiredAction, RunError lastError, DateTimeOffset? expiresAt, DateTimeOffset? startedAt, DateTimeOffset? cancelledAt, DateTimeOffset? failedAt, DateTimeOffset? completedAt, RunIncompleteDetails incompleteDetails, string model, string instructions, IReadOnlyList<ToolDefinition> tools, IReadOnlyDictionary<string, string> metadata, RunTokenUsage usage, float? temperature, float? nucleusSamplingFactor, int? maxPromptTokens, int? maxCompletionTokens, RunTruncationStrategy truncationStrategy, ToolConstraint toolConstraint, AssistantResponseFormat responseFormat, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Id = id;
            _object = @object;
            CreatedAt = createdAt;
            ThreadId = threadId;
            AssistantId = assistantId;
            Status = status;
            _internalRequiredAction = internalRequiredAction;
            LastError = lastError;
            ExpiresAt = expiresAt;
            StartedAt = startedAt;
            CancelledAt = cancelledAt;
            FailedAt = failedAt;
            CompletedAt = completedAt;
            IncompleteDetails = incompleteDetails;
            Model = model;
            Instructions = instructions;
            Tools = tools;
            Metadata = metadata;
            Usage = usage;
            Temperature = temperature;
            NucleusSamplingFactor = nucleusSamplingFactor;
            MaxPromptTokens = maxPromptTokens;
            MaxCompletionTokens = maxCompletionTokens;
            TruncationStrategy = truncationStrategy;
            ToolConstraint = toolConstraint;
            ResponseFormat = responseFormat;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ThreadRun"/> for deserialization. </summary>
        internal ThreadRun()
        {
        }

        /// <summary> The identifier, which can be referenced in API endpoints. </summary>
        public string Id { get; }

        /// <summary> The Unix timestamp (in seconds) for when the run was created. </summary>
        public DateTimeOffset CreatedAt { get; }
        /// <summary> The ID of the [thread](/docs/api-reference/threads) that was executed on as a part of this run. </summary>
        public string ThreadId { get; }
        /// <summary> The ID of the [assistant](/docs/api-reference/assistants) used for execution of this run. </summary>
        public string AssistantId { get; }
        /// <summary> The status of the run, which can be either `queued`, `in_progress`, `requires_action`, `cancelling`, `cancelled`, `failed`, `completed`, `incomplete`, or `expired`. </summary>
        public RunStatus Status { get; }
        /// <summary> The last error associated with this run. Will be `null` if there are no errors. </summary>
        public RunError LastError { get; }
        /// <summary> The Unix timestamp (in seconds) for when the run will expire. </summary>
        public DateTimeOffset? ExpiresAt { get; }
        /// <summary> The Unix timestamp (in seconds) for when the run was started. </summary>
        public DateTimeOffset? StartedAt { get; }
        /// <summary> The Unix timestamp (in seconds) for when the run was cancelled. </summary>
        public DateTimeOffset? CancelledAt { get; }
        /// <summary> The Unix timestamp (in seconds) for when the run failed. </summary>
        public DateTimeOffset? FailedAt { get; }
        /// <summary> The Unix timestamp (in seconds) for when the run was completed. </summary>
        public DateTimeOffset? CompletedAt { get; }
        /// <summary> Details on why the run is incomplete. Will be `null` if the run is not incomplete. </summary>
        public RunIncompleteDetails IncompleteDetails { get; }
        /// <summary> The model that the [assistant](/docs/api-reference/assistants) used for this run. </summary>
        public string Model { get; }
        /// <summary> The instructions that the [assistant](/docs/api-reference/assistants) used for this run. </summary>
        public string Instructions { get; }
        /// <summary>
        /// The list of tools that the [assistant](/docs/api-reference/assistants) used for this run.
        /// Please note <see cref="ToolDefinition"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="CodeInterpreterToolDefinition"/>, <see cref="FileSearchToolDefinition"/> and <see cref="FunctionToolDefinition"/>.
        /// </summary>
        public IReadOnlyList<ToolDefinition> Tools { get; }
        /// <summary> Set of 16 key-value pairs that can be attached to an object. This can be useful for storing additional information about the object in a structured format. Keys can be a maximum of 64 characters long and values can be a maxium of 512 characters long. </summary>
        public IReadOnlyDictionary<string, string> Metadata { get; }
        /// <summary> Gets the usage. </summary>
        public RunTokenUsage Usage { get; }
        /// <summary> The sampling temperature used for this run. If not set, defaults to 1. </summary>
        public float? Temperature { get; }
        /// <summary> The maximum number of prompt tokens specified to have been used over the course of the run. </summary>
        public int? MaxPromptTokens { get; }
        /// <summary> The maximum number of completion tokens specified to have been used over the course of the run. </summary>
        public int? MaxCompletionTokens { get; }
        /// <summary> Gets the truncation strategy. </summary>
        public RunTruncationStrategy TruncationStrategy { get; }
    }
}
