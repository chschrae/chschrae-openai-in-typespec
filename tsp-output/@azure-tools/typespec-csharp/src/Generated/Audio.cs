// <auto-generated/>

#nullable disable

using OpenAI.Models;
using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Threading.Tasks;

namespace OpenAI
{
    // Data plane generated sub-client.
    /// <summary> The Audio sub-client. </summary>
    public partial class Audio
    {
        private const string AuthorizationHeader = "Authorization";
        private readonly ApiKeyCredential _keyCredential;
        private const string AuthorizationApiKeyPrefix = "Bearer";
        private readonly ClientPipeline _pipeline;
        private readonly Uri _endpoint;

        /// <summary> The HTTP pipeline for sending and receiving REST requests and responses. </summary>
        public virtual ClientPipeline Pipeline => _pipeline;

        /// <summary> Initializes a new instance of Audio for mocking. </summary>
        protected Audio()
        {
        }

        /// <summary> Initializes a new instance of Audio. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="keyCredential"> The key credential to copy. </param>
        /// <param name="endpoint"> OpenAI Endpoint. </param>
        internal Audio(ClientPipeline pipeline, ApiKeyCredential keyCredential, Uri endpoint)
        {
            _pipeline = pipeline;
            _keyCredential = keyCredential;
            _endpoint = endpoint;
        }

        /// <summary> Generates audio from the input text. </summary>
        /// <param name="speech"> The <see cref="CreateSpeechRequest"/> to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="speech"/> is null. </exception>
        public virtual async Task<ClientResult<BinaryData>> CreateSpeechAsync(CreateSpeechRequest speech)
        {
            Argument.AssertNotNull(speech, nameof(speech));

            using BinaryContent content = speech.ToBinaryContent();
            ClientResult result = await CreateSpeechAsync(content).ConfigureAwait(false);
            return ClientResult.FromValue(result.GetRawResponse().Content, result.GetRawResponse());
        }

        /// <summary> Generates audio from the input text. </summary>
        /// <param name="speech"> The <see cref="CreateSpeechRequest"/> to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="speech"/> is null. </exception>
        public virtual ClientResult<BinaryData> CreateSpeech(CreateSpeechRequest speech)
        {
            Argument.AssertNotNull(speech, nameof(speech));

            using BinaryContent content = speech.ToBinaryContent();
            ClientResult result = CreateSpeech(content);
            return ClientResult.FromValue(result.GetRawResponse().Content, result.GetRawResponse());
        }

        /// <summary>
        /// [Protocol Method] Generates audio from the input text.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://azsdk/net/protocol/quickstart">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Please try the simpler <see cref="CreateSpeechAsync(CreateSpeechRequest)"/> convenience overload with strongly typed models first.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="options"> The request options, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        /// <exception cref="ClientResultException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        public virtual async Task<ClientResult> CreateSpeechAsync(BinaryContent content, RequestOptions options = null)
        {
            Argument.AssertNotNull(content, nameof(content));

            options ??= new RequestOptions();

            using PipelineMessage message = CreateCreateSpeechRequest(content, options);
            return ClientResult.FromResponse(await _pipeline.ProcessMessageAsync(message, options).ConfigureAwait(false));
        }

        /// <summary>
        /// [Protocol Method] Generates audio from the input text.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://azsdk/net/protocol/quickstart">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Please try the simpler <see cref="CreateSpeech(CreateSpeechRequest)"/> convenience overload with strongly typed models first.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="options"> The request options, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        /// <exception cref="ClientResultException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        public virtual ClientResult CreateSpeech(BinaryContent content, RequestOptions options = null)
        {
            Argument.AssertNotNull(content, nameof(content));

            options ??= new RequestOptions();

            using PipelineMessage message = CreateCreateSpeechRequest(content, options);
            return ClientResult.FromResponse(_pipeline.ProcessMessage(message, options));
        }

        /// <summary> Transcribes audio into the input language. </summary>
        /// <param name="audio"> The <see cref="CreateTranscriptionRequest"/> to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="audio"/> is null. </exception>
        public virtual async Task<ClientResult<CreateTranscriptionResponse>> CreateTranscriptionAsync(CreateTranscriptionRequest audio)
        {
            Argument.AssertNotNull(audio, nameof(audio));

            using MultipartFormDataBinaryContent content = audio.ToMultipartContent();
            ClientResult result = await CreateTranscriptionAsync(content, content.ContentType).ConfigureAwait(false);
            return ClientResult.FromValue(CreateTranscriptionResponse.FromResponse(result.GetRawResponse()), result.GetRawResponse());
        }

        /// <summary> Transcribes audio into the input language. </summary>
        /// <param name="audio"> The <see cref="CreateTranscriptionRequest"/> to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="audio"/> is null. </exception>
        public virtual ClientResult<CreateTranscriptionResponse> CreateTranscription(CreateTranscriptionRequest audio)
        {
            Argument.AssertNotNull(audio, nameof(audio));

            using MultipartFormDataBinaryContent content = audio.ToMultipartContent();
            ClientResult result = CreateTranscription(content, content.ContentType);
            return ClientResult.FromValue(CreateTranscriptionResponse.FromResponse(result.GetRawResponse()), result.GetRawResponse());
        }

        /// <summary>
        /// [Protocol Method] Transcribes audio into the input language.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://azsdk/net/protocol/quickstart">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Please try the simpler <see cref="CreateTranscriptionAsync(CreateTranscriptionRequest)"/> convenience overload with strongly typed models first.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="contentType">The content type of the content in the body of the request.</param>
        /// <param name="options"> The request options, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        /// <exception cref="ClientResultException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        public virtual async Task<ClientResult> CreateTranscriptionAsync(BinaryContent content, string contentType, RequestOptions options = null)
        {
            Argument.AssertNotNull(content, nameof(content));

            options ??= new RequestOptions();

            using PipelineMessage message = CreateCreateTranscriptionRequest(content, contentType, options);
            return ClientResult.FromResponse(await _pipeline.ProcessMessageAsync(message, options).ConfigureAwait(false));
        }

        /// <summary>
        /// [Protocol Method] Transcribes audio into the input language.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://azsdk/net/protocol/quickstart">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Please try the simpler <see cref="CreateTranscription(CreateTranscriptionRequest)"/> convenience overload with strongly typed models first.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="contentType">The content type of the content in the body of the request.</param>
        /// <param name="options"> The request options, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        /// <exception cref="ClientResultException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        public virtual ClientResult CreateTranscription(BinaryContent content, string contentType, RequestOptions options = null)
        {
            Argument.AssertNotNull(content, nameof(content));

            options ??= new RequestOptions();

            using PipelineMessage message = CreateCreateTranscriptionRequest(content, contentType, options);
            return ClientResult.FromResponse(_pipeline.ProcessMessage(message, options));
        }

        /// <summary> Translates audio into English.. </summary>
        /// <param name="audio"> The <see cref="CreateTranslationRequest"/> to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="audio"/> is null. </exception>
        public virtual async Task<ClientResult<CreateTranslationResponse>> CreateTranslationAsync(CreateTranslationRequest audio)
        {
            Argument.AssertNotNull(audio, nameof(audio));

            using MultipartFormDataBinaryContent content = audio.ToMultipartContent();
            ClientResult result = await CreateTranslationAsync(content,content.ContentType).ConfigureAwait(false);
            return ClientResult.FromValue(CreateTranslationResponse.FromResponse(result.GetRawResponse()), result.GetRawResponse());
        }

        /// <summary> Translates audio into English.. </summary>
        /// <param name="audio"> The <see cref="CreateTranslationRequest"/> to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="audio"/> is null. </exception>
        public virtual ClientResult<CreateTranslationResponse> CreateTranslation(CreateTranslationRequest audio)
        {
            Argument.AssertNotNull(audio, nameof(audio));

            using MultipartFormDataBinaryContent content = audio.ToMultipartContent();
            ClientResult result = CreateTranslation(content, content.ContentType);
            return ClientResult.FromValue(CreateTranslationResponse.FromResponse(result.GetRawResponse()), result.GetRawResponse());
        }

        /// <summary>
        /// [Protocol Method] Translates audio into English..
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://azsdk/net/protocol/quickstart">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Please try the simpler <see cref="CreateTranslationAsync(CreateTranslationRequest)"/> convenience overload with strongly typed models first.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="contentType">The content type of the content in the body of the request.</param>
        /// <param name="options"> The request options, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        /// <exception cref="ClientResultException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        public virtual async Task<ClientResult> CreateTranslationAsync(BinaryContent content, string contentType, RequestOptions options = null)
        {
            Argument.AssertNotNull(content, nameof(content));

            options ??= new RequestOptions();

            using PipelineMessage message = CreateCreateTranslationRequest(content, contentType, options);
            return ClientResult.FromResponse(await _pipeline.ProcessMessageAsync(message, options).ConfigureAwait(false));
        }

        /// <summary>
        /// [Protocol Method] Translates audio into English..
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://azsdk/net/protocol/quickstart">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Please try the simpler <see cref="CreateTranslation(CreateTranslationRequest)"/> convenience overload with strongly typed models first.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="contentType">The content type of the content in the body of the request.</param>
        /// <param name="options"> The request options, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        /// <exception cref="ClientResultException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        public virtual ClientResult CreateTranslation(BinaryContent content, string contentType, RequestOptions options = null)
        {
            Argument.AssertNotNull(content, nameof(content));

            options ??= new RequestOptions();

            using PipelineMessage message = CreateCreateTranslationRequest(content, contentType, options);
            return ClientResult.FromResponse(_pipeline.ProcessMessage(message, options));
        }

        private PipelineMessage CreateCreateSpeechRequest(BinaryContent content, RequestOptions options)
        {
            var message = _pipeline.CreateMessage();
            message.ResponseClassifier = PipelineMessageClassifier200;
            var request = message.Request;
            request.Method = "POST";
            var uri = new ClientUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/audio/speech", false);
            request.Uri = uri.ToUri();
            request.Headers.Set("Accept", "application/octet-stream");
            request.Headers.Set("Content-Type", "application/json");
            request.Content = content;
            message.Apply(options);
            return message;
        }

        private PipelineMessage CreateCreateTranscriptionRequest(BinaryContent content, string contentType, RequestOptions options)
        {
            var message = _pipeline.CreateMessage();
            message.ResponseClassifier = PipelineMessageClassifier200;
            var request = message.Request;
            request.Method = "POST";
            var uri = new ClientUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/audio/transcriptions", false);
            request.Uri = uri.ToUri();
            request.Headers.Set("Accept", "application/json");
            request.Headers.Set("Content-Type", contentType);
            request.Content = content;
            message.Apply(options);
            return message;
        }

        private PipelineMessage CreateCreateTranslationRequest(BinaryContent content, string contentType, RequestOptions options)
        {
            var message = _pipeline.CreateMessage();
            message.ResponseClassifier = PipelineMessageClassifier200;
            var request = message.Request;
            request.Method = "POST";
            var uri = new ClientUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/audio/translations", false);
            request.Uri = uri.ToUri();
            request.Headers.Set("Accept", "application/json");
            request.Headers.Set("Content-Type", contentType);
            request.Content = content;
            message.Apply(options);
            return message;
        }

        private static PipelineMessageClassifier _pipelineMessageClassifier200;
        private static PipelineMessageClassifier PipelineMessageClassifier200 => _pipelineMessageClassifier200 ??= PipelineMessageClassifier.Create(stackalloc ushort[] { 200 });
    }
}
