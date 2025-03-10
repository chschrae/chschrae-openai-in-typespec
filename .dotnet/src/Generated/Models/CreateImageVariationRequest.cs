// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.Internal.Models
{
    /// <summary> The CreateImageVariationRequest. </summary>
    internal partial class CreateImageVariationRequest
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

        /// <summary> Initializes a new instance of <see cref="CreateImageVariationRequest"/>. </summary>
        /// <param name="image">
        /// The image to use as the basis for the variation(s). Must be a valid PNG file, less than 4MB,
        /// and square.
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="image"/> is null. </exception>
        public CreateImageVariationRequest(BinaryData image)
        {
            Argument.AssertNotNull(image, nameof(image));

            Image = image;
        }

        /// <summary> Initializes a new instance of <see cref="CreateImageVariationRequest"/>. </summary>
        /// <param name="image">
        /// The image to use as the basis for the variation(s). Must be a valid PNG file, less than 4MB,
        /// and square.
        /// </param>
        /// <param name="model"> The model to use for image generation. Only `dall-e-2` is supported at this time. </param>
        /// <param name="n"> The number of images to generate. Must be between 1 and 10. </param>
        /// <param name="responseFormat"> The format in which the generated images are returned. Must be one of `url` or `b64_json`. </param>
        /// <param name="size"> The size of the generated images. Must be one of `256x256`, `512x512`, or `1024x1024`. </param>
        /// <param name="user">
        /// A unique identifier representing your end-user, which can help OpenAI to monitor and detect
        /// abuse. [Learn more](/docs/guides/safety-best-practices/end-user-ids).
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CreateImageVariationRequest(BinaryData image, CreateImageVariationRequestModel? model, long? n, CreateImageVariationRequestResponseFormat? responseFormat, CreateImageVariationRequestSize? size, string user, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Image = image;
            Model = model;
            N = n;
            ResponseFormat = responseFormat;
            Size = size;
            User = user;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="CreateImageVariationRequest"/> for deserialization. </summary>
        internal CreateImageVariationRequest()
        {
        }

        /// <summary>
        /// The image to use as the basis for the variation(s). Must be a valid PNG file, less than 4MB,
        /// and square.
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
        public BinaryData Image { get; }
        /// <summary> The model to use for image generation. Only `dall-e-2` is supported at this time. </summary>
        public CreateImageVariationRequestModel? Model { get; set; }
        /// <summary> The number of images to generate. Must be between 1 and 10. </summary>
        public long? N { get; set; }
        /// <summary> The format in which the generated images are returned. Must be one of `url` or `b64_json`. </summary>
        public CreateImageVariationRequestResponseFormat? ResponseFormat { get; set; }
        /// <summary> The size of the generated images. Must be one of `256x256`, `512x512`, or `1024x1024`. </summary>
        public CreateImageVariationRequestSize? Size { get; set; }
        /// <summary>
        /// A unique identifier representing your end-user, which can help OpenAI to monitor and detect
        /// abuse. [Learn more](/docs/guides/safety-best-practices/end-user-ids).
        /// </summary>
        public string User { get; set; }
    }
}
