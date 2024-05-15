// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.Assistants
{
    /// <summary> The MessageDeltaObjectDelta. </summary>
    internal partial class MessageDeltaObjectDelta
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

        /// <summary> Initializes a new instance of <see cref="MessageDeltaObjectDelta"/>. </summary>
        internal MessageDeltaObjectDelta()
        {
            Content = new ChangeTrackingList<MessageDeltaContent>();
        }

        /// <summary> Initializes a new instance of <see cref="MessageDeltaObjectDelta"/>. </summary>
        /// <param name="role"> The entity that produced the message. One of `user` or `assistant`. </param>
        /// <param name="content">
        /// The content of the message in array of text and/or images.
        /// Please note <see cref="MessageDeltaContent"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="MessageDeltaContentImageFileObject"/>, <see cref="MessageDeltaContentImageUrlObject"/> and <see cref="MessageDeltaContentTextObject"/>.
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MessageDeltaObjectDelta(MessageRole role, IReadOnlyList<MessageDeltaContent> content, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Role = role;
            Content = content;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }
        /// <summary>
        /// The content of the message in array of text and/or images.
        /// Please note <see cref="MessageDeltaContent"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="MessageDeltaContentImageFileObject"/>, <see cref="MessageDeltaContentImageUrlObject"/> and <see cref="MessageDeltaContentTextObject"/>.
        /// </summary>
        public IReadOnlyList<MessageDeltaContent> Content { get; }
    }
}
