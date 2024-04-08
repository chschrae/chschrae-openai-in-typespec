// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.Models
{
    /// <summary> The CreateRunRequest. </summary>
    public partial class CreateRunRequest
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

        /// <summary> Initializes a new instance of <see cref="CreateRunRequest"/>. </summary>
        /// <param name="assistantId"> The ID of the [assistant](/docs/api-reference/assistants) to use to execute this run. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="assistantId"/> is null. </exception>
        public CreateRunRequest(string assistantId)
        {
            Argument.AssertNotNull(assistantId, nameof(assistantId));

            AssistantId = assistantId;
            Tools = new ChangeTrackingList<BinaryData>();
            Metadata = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="CreateRunRequest"/>. </summary>
        /// <param name="assistantId"> The ID of the [assistant](/docs/api-reference/assistants) to use to execute this run. </param>
        /// <param name="model">
        /// The ID of the [Model](/docs/api-reference/models) to be used to execute this run. If a value
        /// is provided here, it will override the model associated with the assistant. If not, the model
        /// associated with the assistant will be used.
        /// </param>
        /// <param name="instructions">
        /// Overrides the [instructions](/docs/api-reference/assistants/createAssistant) of the assistant.
        /// This is useful for modifying the behavior on a per-run basis.
        /// </param>
        /// <param name="additionalInstructions">
        /// Appends additional instructions at the end of the instructions for the run. This is useful for
        /// modifying the behavior on a per-run basis without overriding other instructions.
        /// </param>
        /// <param name="tools">
        /// Override the tools the assistant can use for this run. This is useful for modifying the
        /// behavior on a per-run basis.
        /// </param>
        /// <param name="metadata">
        /// Set of 16 key-value pairs that can be attached to an object. This can be useful for storing
        /// additional information about the object in a structured format. Keys can be a maximum of 64
        /// characters long and values can be a maxium of 512 characters long.
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CreateRunRequest(string assistantId, string model, string instructions, string additionalInstructions, IList<BinaryData> tools, IDictionary<string, string> metadata, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            AssistantId = assistantId;
            Model = model;
            Instructions = instructions;
            AdditionalInstructions = additionalInstructions;
            Tools = tools;
            Metadata = metadata;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="CreateRunRequest"/> for deserialization. </summary>
        internal CreateRunRequest()
        {
        }

        /// <summary> The ID of the [assistant](/docs/api-reference/assistants) to use to execute this run. </summary>
        public string AssistantId { get; }
        /// <summary>
        /// The ID of the [Model](/docs/api-reference/models) to be used to execute this run. If a value
        /// is provided here, it will override the model associated with the assistant. If not, the model
        /// associated with the assistant will be used.
        /// </summary>
        public string Model { get; set; }
        /// <summary>
        /// Overrides the [instructions](/docs/api-reference/assistants/createAssistant) of the assistant.
        /// This is useful for modifying the behavior on a per-run basis.
        /// </summary>
        public string Instructions { get; set; }
        /// <summary>
        /// Appends additional instructions at the end of the instructions for the run. This is useful for
        /// modifying the behavior on a per-run basis without overriding other instructions.
        /// </summary>
        public string AdditionalInstructions { get; set; }
        /// <summary>
        /// Override the tools the assistant can use for this run. This is useful for modifying the
        /// behavior on a per-run basis.
        /// <para>
        /// To assign an object to the element of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
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
        public IList<BinaryData> Tools { get; set; }
        /// <summary>
        /// Set of 16 key-value pairs that can be attached to an object. This can be useful for storing
        /// additional information about the object in a structured format. Keys can be a maximum of 64
        /// characters long and values can be a maxium of 512 characters long.
        /// </summary>
        public IDictionary<string, string> Metadata { get; set; }
    }
}
