// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.Internal.Models
{
    /// <summary> The ModifyRunRequest. </summary>
    internal partial class ModifyRunRequest
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

        /// <summary> Initializes a new instance of <see cref="ModifyRunRequest"/>. </summary>
        public ModifyRunRequest()
        {
            Metadata = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="ModifyRunRequest"/>. </summary>
        /// <param name="metadata">
        /// Set of 16 key-value pairs that can be attached to an object. This can be useful for storing
        /// additional information about the object in a structured format. Keys can be a maximum of 64
        /// characters long and values can be a maxium of 512 characters long.
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ModifyRunRequest(IDictionary<string, string> metadata, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Metadata = metadata;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary>
        /// Set of 16 key-value pairs that can be attached to an object. This can be useful for storing
        /// additional information about the object in a structured format. Keys can be a maximum of 64
        /// characters long and values can be a maxium of 512 characters long.
        /// </summary>
        public IDictionary<string, string> Metadata { get; set; }
    }
}
