// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.Internal.Models
{
    /// <summary> The DeleteAssistantResponse. </summary>
    internal partial class DeleteAssistantResponse
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

        /// <summary> Initializes a new instance of <see cref="DeleteAssistantResponse"/>. </summary>
        /// <param name="id"></param>
        /// <param name="deleted"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        internal DeleteAssistantResponse(string id, bool deleted)
        {
            Argument.AssertNotNull(id, nameof(id));

            Id = id;
            Deleted = deleted;
        }

        /// <summary> Initializes a new instance of <see cref="DeleteAssistantResponse"/>. </summary>
        /// <param name="id"></param>
        /// <param name="deleted"></param>
        /// <param name="object"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DeleteAssistantResponse(string id, bool deleted, DeleteAssistantResponseObject @object, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Id = id;
            Deleted = deleted;
            Object = @object;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="DeleteAssistantResponse"/> for deserialization. </summary>
        internal DeleteAssistantResponse()
        {
        }

        /// <summary> Gets the id. </summary>
        public string Id { get; }
        /// <summary> Gets the deleted. </summary>
        public bool Deleted { get; }
        /// <summary> Gets the object. </summary>
        public DeleteAssistantResponseObject Object { get; } = DeleteAssistantResponseObject.AssistantDeleted;
    }
}
