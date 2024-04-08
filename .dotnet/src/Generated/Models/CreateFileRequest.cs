// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.Internal.Models
{
    /// <summary> The CreateFileRequest. </summary>
    internal partial class CreateFileRequest
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

        /// <summary> Initializes a new instance of <see cref="CreateFileRequest"/>. </summary>
        /// <param name="file"> The file object (not file name) to be uploaded. </param>
        /// <param name="purpose">
        /// The intended purpose of the uploaded file. Use "fine-tune" for
        /// [Fine-tuning](/docs/api-reference/fine-tuning) and "assistants" for
        /// [Assistants](/docs/api-reference/assistants) and [Messages](/docs/api-reference/messages). This
        /// allows us to validate the format of the uploaded file is correct for fine-tuning.
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="file"/> is null. </exception>
        public CreateFileRequest(BinaryData file, CreateFileRequestPurpose purpose)
        {
            Argument.AssertNotNull(file, nameof(file));

            File = file;
            Purpose = purpose;
        }

        /// <summary> Initializes a new instance of <see cref="CreateFileRequest"/>. </summary>
        /// <param name="file"> The file object (not file name) to be uploaded. </param>
        /// <param name="purpose">
        /// The intended purpose of the uploaded file. Use "fine-tune" for
        /// [Fine-tuning](/docs/api-reference/fine-tuning) and "assistants" for
        /// [Assistants](/docs/api-reference/assistants) and [Messages](/docs/api-reference/messages). This
        /// allows us to validate the format of the uploaded file is correct for fine-tuning.
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CreateFileRequest(BinaryData file, CreateFileRequestPurpose purpose, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            File = file;
            Purpose = purpose;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="CreateFileRequest"/> for deserialization. </summary>
        internal CreateFileRequest()
        {
        }

        /// <summary>
        /// The file object (not file name) to be uploaded.
        /// <para>
        /// To assign a byte[] to this property use <see cref="BinaryData.FromBytes(byte[])"/>.
        /// The byte[] will be serialized to a Base64 encoded string.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromBytes(new byte[] { 1, 2, 3 })</term>
        /// <description>Creates a payload of "AQID".</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        public BinaryData File { get; }
        /// <summary>
        /// The intended purpose of the uploaded file. Use "fine-tune" for
        /// [Fine-tuning](/docs/api-reference/fine-tuning) and "assistants" for
        /// [Assistants](/docs/api-reference/assistants) and [Messages](/docs/api-reference/messages). This
        /// allows us to validate the format of the uploaded file is correct for fine-tuning.
        /// </summary>
        public CreateFileRequestPurpose Purpose { get; }
    }
}
