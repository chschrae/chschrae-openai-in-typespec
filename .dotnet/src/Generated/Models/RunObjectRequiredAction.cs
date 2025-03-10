// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.Internal.Models
{
    /// <summary> The RunObjectRequiredAction. </summary>
    internal partial class RunObjectRequiredAction
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

        /// <summary> Initializes a new instance of <see cref="RunObjectRequiredAction"/>. </summary>
        /// <param name="submitToolOutputs"> Details on the tool outputs needed for this run to continue. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="submitToolOutputs"/> is null. </exception>
        internal RunObjectRequiredAction(RunObjectRequiredActionSubmitToolOutputs submitToolOutputs)
        {
            Argument.AssertNotNull(submitToolOutputs, nameof(submitToolOutputs));

            SubmitToolOutputs = submitToolOutputs;
        }

        /// <summary> Initializes a new instance of <see cref="RunObjectRequiredAction"/>. </summary>
        /// <param name="type"> For now, this is always `submit_tool_outputs`. </param>
        /// <param name="submitToolOutputs"> Details on the tool outputs needed for this run to continue. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal RunObjectRequiredAction(RunObjectRequiredActionType type, RunObjectRequiredActionSubmitToolOutputs submitToolOutputs, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Type = type;
            SubmitToolOutputs = submitToolOutputs;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="RunObjectRequiredAction"/> for deserialization. </summary>
        internal RunObjectRequiredAction()
        {
        }

        /// <summary> For now, this is always `submit_tool_outputs`. </summary>
        public RunObjectRequiredActionType Type { get; } = RunObjectRequiredActionType.SubmitToolOutputs;

        /// <summary> Details on the tool outputs needed for this run to continue. </summary>
        public RunObjectRequiredActionSubmitToolOutputs SubmitToolOutputs { get; }
    }
}
