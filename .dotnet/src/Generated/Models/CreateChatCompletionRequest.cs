// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace OpenAI.Internal.Models
{
    /// <summary> The CreateChatCompletionRequest. </summary>
    internal partial class CreateChatCompletionRequest
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

        /// <summary> Initializes a new instance of <see cref="CreateChatCompletionRequest"/>. </summary>
        /// <param name="messages">
        /// A list of messages comprising the conversation so far.
        /// [Example Python code](https://github.com/openai/openai-cookbook/blob/main/examples/How_to_format_inputs_to_ChatGPT_models.ipynb).
        /// </param>
        /// <param name="model">
        /// ID of the model to use. See the [model endpoint compatibility](/docs/models/model-endpoint-compatibility)
        /// table for details on which models work with the Chat API.
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="messages"/> is null. </exception>
        public CreateChatCompletionRequest(IEnumerable<BinaryData> messages, CreateChatCompletionRequestModel model)
        {
            Argument.AssertNotNull(messages, nameof(messages));

            Messages = messages.ToList();
            Model = model;
            LogitBias = new ChangeTrackingDictionary<string, long>();
            Tools = new ChangeTrackingList<ChatCompletionTool>();
            Functions = new ChangeTrackingList<ChatCompletionFunctions>();
        }

        /// <summary> Initializes a new instance of <see cref="CreateChatCompletionRequest"/>. </summary>
        /// <param name="messages">
        /// A list of messages comprising the conversation so far.
        /// [Example Python code](https://github.com/openai/openai-cookbook/blob/main/examples/How_to_format_inputs_to_ChatGPT_models.ipynb).
        /// </param>
        /// <param name="model">
        /// ID of the model to use. See the [model endpoint compatibility](/docs/models/model-endpoint-compatibility)
        /// table for details on which models work with the Chat API.
        /// </param>
        /// <param name="frequencyPenalty">
        /// Number between -2.0 and 2.0. Positive values penalize new tokens based on their existing
        /// frequency in the text so far, decreasing the model's likelihood to repeat the same line
        /// verbatim.
        ///
        /// [See more information about frequency and presence penalties.](/docs/guides/gpt/parameter-details)
        /// </param>
        /// <param name="logitBias">
        /// Modify the likelihood of specified tokens appearing in the completion.
        ///
        /// Accepts a JSON object that maps tokens (specified by their token ID in the tokenizer) to an
        /// associated bias value from -100 to 100. Mathematically, the bias is added to the logits
        /// generated by the model prior to sampling. The exact effect will vary per model, but values
        /// between -1 and 1 should decrease or increase likelihood of selection; values like -100 or 100
        /// should result in a ban or exclusive selection of the relevant token.
        /// </param>
        /// <param name="logprobs">
        /// Whether to return log probabilities of the output tokens or not. If true, returns the log
        /// probabilities of each output token returned in the `content` of `message`. This option is
        /// currently not available on the `gpt-4-vision-preview` model.
        /// </param>
        /// <param name="topLogprobs">
        /// An integer between 0 and 20 specifying the number of most likely tokens to return at each token
        /// position, each with an associated log probability. `logprobs` must be set to `true` if this
        /// parameter is used.
        /// </param>
        /// <param name="maxTokens">
        /// The maximum number of [tokens](/tokenizer) that can be generated in the chat completion.
        ///
        /// The total length of input tokens and generated tokens is limited by the model's context length.
        /// [Example Python code](https://cookbook.openai.com/examples/how_to_count_tokens_with_tiktoken)
        /// for counting tokens.
        /// </param>
        /// <param name="n">
        /// How many chat completion choices to generate for each input message. Note that you will be
        /// charged based on the number of generated tokens across all of the choices. Keep `n` as `1` to
        /// minimize costs.
        /// </param>
        /// <param name="presencePenalty">
        /// Number between -2.0 and 2.0. Positive values penalize new tokens based on whether they appear
        /// in the text so far, increasing the model's likelihood to talk about new topics.
        ///
        /// [See more information about frequency and presence penalties.](/docs/guides/gpt/parameter-details)
        /// </param>
        /// <param name="responseFormat">
        /// An object specifying the format that the model must output. Compatible with
        /// [GPT-4 Turbo](/docs/models/gpt-4-and-gpt-4-turbo) and all GPT-3.5 Turbo models newer than
        /// `gpt-3.5-turbo-1106`.
        ///
        /// Setting to `{ "type": "json_object" }` enables JSON mode, which guarantees the message the
        /// model generates is valid JSON.
        ///
        /// **Important:** when using JSON mode, you **must** also instruct the model to produce JSON
        /// yourself via a system or user message. Without this, the model may generate an unending stream
        /// of whitespace until the generation reaches the token limit, resulting in a long-running and
        /// seemingly "stuck" request. Also note that the message content may be partially cut off if
        /// `finish_reason="length"`, which indicates the generation exceeded `max_tokens` or the
        /// conversation exceeded the max context length.
        /// </param>
        /// <param name="seed">
        /// This feature is in Beta.
        ///
        /// If specified, our system will make a best effort to sample deterministically, such that
        /// repeated requests with the same `seed` and parameters should return the same result.
        ///
        /// Determinism is not guaranteed, and you should refer to the `system_fingerprint` response
        /// parameter to monitor changes in the backend.
        /// </param>
        /// <param name="stop"> Up to 4 sequences where the API will stop generating further tokens. </param>
        /// <param name="stream">
        /// If set, partial message deltas will be sent, like in ChatGPT. Tokens will be sent as data-only
        /// [server-sent events](https://developer.mozilla.org/en-US/docs/Web/API/Server-sent_events/Using_server-sent_events#Event_stream_format)
        /// as they become available, with the stream terminated by a `data: [DONE]` message.
        /// [Example Python code](https://cookbook.openai.com/examples/how_to_stream_completions).
        /// </param>
        /// <param name="temperature">
        /// What sampling temperature to use, between 0 and 2. Higher values like 0.8 will make the output
        /// more random, while lower values like 0.2 will make it more focused and deterministic.
        ///
        /// We generally recommend altering this or `top_p` but not both.
        /// </param>
        /// <param name="topP">
        /// An alternative to sampling with temperature, called nucleus sampling, where the model considers
        /// the results of the tokens with top_p probability mass. So 0.1 means only the tokens comprising
        /// the top 10% probability mass are considered.
        ///
        /// We generally recommend altering this or `temperature` but not both.
        /// </param>
        /// <param name="tools">
        /// A list of tools the model may call. Currently, only functions are supported as a tool. Use this
        /// to provide a list of functions the model may generate JSON inputs for.
        /// </param>
        /// <param name="toolChoice"></param>
        /// <param name="user">
        /// A unique identifier representing your end-user, which can help OpenAI to monitor and detect
        /// abuse. [Learn more](/docs/guides/safety-best-practices/end-user-ids).
        /// </param>
        /// <param name="functionCall">
        /// Deprecated in favor of `tool_choice`.
        ///
        /// Controls which (if any) function is called by the model. `none` means the model will not call a
        /// function and instead generates a message. `auto` means the model can pick between generating a
        /// message or calling a function. Specifying a particular function via `{"name": "my_function"}`
        /// forces the model to call that function.
        ///
        /// `none` is the default when no functions are present. `auto` is the default if functions are
        /// present.
        /// </param>
        /// <param name="functions">
        /// Deprecated in favor of `tools`.
        ///
        /// A list of functions the model may generate JSON inputs for.
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CreateChatCompletionRequest(IList<BinaryData> messages, CreateChatCompletionRequestModel model, double? frequencyPenalty, IDictionary<string, long> logitBias, bool? logprobs, long? topLogprobs, long? maxTokens, long? n, double? presencePenalty, CreateChatCompletionRequestResponseFormat responseFormat, long? seed, BinaryData stop, bool? stream, double? temperature, double? topP, IList<ChatCompletionTool> tools, BinaryData toolChoice, string user, BinaryData functionCall, IList<ChatCompletionFunctions> functions, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Messages = messages;
            Model = model;
            FrequencyPenalty = frequencyPenalty;
            LogitBias = logitBias;
            Logprobs = logprobs;
            TopLogprobs = topLogprobs;
            MaxTokens = maxTokens;
            N = n;
            PresencePenalty = presencePenalty;
            ResponseFormat = responseFormat;
            Seed = seed;
            Stop = stop;
            Stream = stream;
            Temperature = temperature;
            TopP = topP;
            Tools = tools;
            ToolChoice = toolChoice;
            User = user;
            FunctionCall = functionCall;
            Functions = functions;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="CreateChatCompletionRequest"/> for deserialization. </summary>
        internal CreateChatCompletionRequest()
        {
        }

        /// <summary>
        /// A list of messages comprising the conversation so far.
        /// [Example Python code](https://github.com/openai/openai-cookbook/blob/main/examples/How_to_format_inputs_to_ChatGPT_models.ipynb).
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
        public IList<BinaryData> Messages { get; }
        /// <summary>
        /// ID of the model to use. See the [model endpoint compatibility](/docs/models/model-endpoint-compatibility)
        /// table for details on which models work with the Chat API.
        /// </summary>
        public CreateChatCompletionRequestModel Model { get; }
        /// <summary>
        /// Number between -2.0 and 2.0. Positive values penalize new tokens based on their existing
        /// frequency in the text so far, decreasing the model's likelihood to repeat the same line
        /// verbatim.
        ///
        /// [See more information about frequency and presence penalties.](/docs/guides/gpt/parameter-details)
        /// </summary>
        public double? FrequencyPenalty { get; set; }
        /// <summary>
        /// Modify the likelihood of specified tokens appearing in the completion.
        ///
        /// Accepts a JSON object that maps tokens (specified by their token ID in the tokenizer) to an
        /// associated bias value from -100 to 100. Mathematically, the bias is added to the logits
        /// generated by the model prior to sampling. The exact effect will vary per model, but values
        /// between -1 and 1 should decrease or increase likelihood of selection; values like -100 or 100
        /// should result in a ban or exclusive selection of the relevant token.
        /// </summary>
        public IDictionary<string, long> LogitBias { get; set; }
        /// <summary>
        /// Whether to return log probabilities of the output tokens or not. If true, returns the log
        /// probabilities of each output token returned in the `content` of `message`. This option is
        /// currently not available on the `gpt-4-vision-preview` model.
        /// </summary>
        public bool? Logprobs { get; set; }
        /// <summary>
        /// An integer between 0 and 20 specifying the number of most likely tokens to return at each token
        /// position, each with an associated log probability. `logprobs` must be set to `true` if this
        /// parameter is used.
        /// </summary>
        public long? TopLogprobs { get; set; }
        /// <summary>
        /// The maximum number of [tokens](/tokenizer) that can be generated in the chat completion.
        ///
        /// The total length of input tokens and generated tokens is limited by the model's context length.
        /// [Example Python code](https://cookbook.openai.com/examples/how_to_count_tokens_with_tiktoken)
        /// for counting tokens.
        /// </summary>
        public long? MaxTokens { get; set; }
        /// <summary>
        /// How many chat completion choices to generate for each input message. Note that you will be
        /// charged based on the number of generated tokens across all of the choices. Keep `n` as `1` to
        /// minimize costs.
        /// </summary>
        public long? N { get; set; }
        /// <summary>
        /// Number between -2.0 and 2.0. Positive values penalize new tokens based on whether they appear
        /// in the text so far, increasing the model's likelihood to talk about new topics.
        ///
        /// [See more information about frequency and presence penalties.](/docs/guides/gpt/parameter-details)
        /// </summary>
        public double? PresencePenalty { get; set; }
        /// <summary>
        /// An object specifying the format that the model must output. Compatible with
        /// [GPT-4 Turbo](/docs/models/gpt-4-and-gpt-4-turbo) and all GPT-3.5 Turbo models newer than
        /// `gpt-3.5-turbo-1106`.
        ///
        /// Setting to `{ "type": "json_object" }` enables JSON mode, which guarantees the message the
        /// model generates is valid JSON.
        ///
        /// **Important:** when using JSON mode, you **must** also instruct the model to produce JSON
        /// yourself via a system or user message. Without this, the model may generate an unending stream
        /// of whitespace until the generation reaches the token limit, resulting in a long-running and
        /// seemingly "stuck" request. Also note that the message content may be partially cut off if
        /// `finish_reason="length"`, which indicates the generation exceeded `max_tokens` or the
        /// conversation exceeded the max context length.
        /// </summary>
        public CreateChatCompletionRequestResponseFormat ResponseFormat { get; set; }
        /// <summary>
        /// This feature is in Beta.
        ///
        /// If specified, our system will make a best effort to sample deterministically, such that
        /// repeated requests with the same `seed` and parameters should return the same result.
        ///
        /// Determinism is not guaranteed, and you should refer to the `system_fingerprint` response
        /// parameter to monitor changes in the backend.
        /// </summary>
        public long? Seed { get; set; }
        /// <summary>
        /// Up to 4 sequences where the API will stop generating further tokens.
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
        /// <description><see cref="string"/></description>
        /// </item>
        /// <item>
        /// <description><see cref="IList{T}"/> where <c>T</c> is of type <see cref="string"/></description>
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
        public BinaryData Stop { get; set; }
        /// <summary>
        /// If set, partial message deltas will be sent, like in ChatGPT. Tokens will be sent as data-only
        /// [server-sent events](https://developer.mozilla.org/en-US/docs/Web/API/Server-sent_events/Using_server-sent_events#Event_stream_format)
        /// as they become available, with the stream terminated by a `data: [DONE]` message.
        /// [Example Python code](https://cookbook.openai.com/examples/how_to_stream_completions).
        /// </summary>
        public bool? Stream { get; set; }
        /// <summary>
        /// What sampling temperature to use, between 0 and 2. Higher values like 0.8 will make the output
        /// more random, while lower values like 0.2 will make it more focused and deterministic.
        ///
        /// We generally recommend altering this or `top_p` but not both.
        /// </summary>
        public double? Temperature { get; set; }
        /// <summary>
        /// An alternative to sampling with temperature, called nucleus sampling, where the model considers
        /// the results of the tokens with top_p probability mass. So 0.1 means only the tokens comprising
        /// the top 10% probability mass are considered.
        ///
        /// We generally recommend altering this or `temperature` but not both.
        /// </summary>
        public double? TopP { get; set; }
        /// <summary>
        /// A list of tools the model may call. Currently, only functions are supported as a tool. Use this
        /// to provide a list of functions the model may generate JSON inputs for.
        /// </summary>
        public IList<ChatCompletionTool> Tools { get; }
        /// <summary>
        /// Gets or sets the tool choice
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
        /// <description>"none"</description>
        /// </item>
        /// <item>
        /// <description>"auto"</description>
        /// </item>
        /// <item>
        /// <description><see cref="ChatCompletionNamedToolChoice"/></description>
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
        public BinaryData ToolChoice { get; set; }
        /// <summary>
        /// A unique identifier representing your end-user, which can help OpenAI to monitor and detect
        /// abuse. [Learn more](/docs/guides/safety-best-practices/end-user-ids).
        /// </summary>
        public string User { get; set; }
        /// <summary>
        /// Deprecated in favor of `tool_choice`.
        ///
        /// Controls which (if any) function is called by the model. `none` means the model will not call a
        /// function and instead generates a message. `auto` means the model can pick between generating a
        /// message or calling a function. Specifying a particular function via `{"name": "my_function"}`
        /// forces the model to call that function.
        ///
        /// `none` is the default when no functions are present. `auto` is the default if functions are
        /// present.
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
        /// <description>"none"</description>
        /// </item>
        /// <item>
        /// <description>"auto"</description>
        /// </item>
        /// <item>
        /// <description><see cref="ChatCompletionFunctionCallOption"/></description>
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
        public BinaryData FunctionCall { get; set; }
        /// <summary>
        /// Deprecated in favor of `tools`.
        ///
        /// A list of functions the model may generate JSON inputs for.
        /// </summary>
        public IList<ChatCompletionFunctions> Functions { get; }
    }
}
