// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Threading;
using System.Threading.Tasks;
using OpenAI.Models;

namespace OpenAI
{
    // Data plane generated sub-client.
    /// <summary> The Files sub-client. </summary>
    public partial class Files
    {
        private const string AuthorizationHeader = "Authorization";
        private readonly ApiKeyCredential _keyCredential;
        private const string AuthorizationApiKeyPrefix = "Bearer";
        private readonly ClientPipeline _pipeline;
        private readonly Uri _endpoint;

        /// <summary> The HTTP pipeline for sending and receiving REST requests and responses. </summary>
        public virtual ClientPipeline Pipeline => _pipeline;

        /// <summary> Initializes a new instance of Files for mocking. </summary>
        protected Files()
        {
        }

        /// <summary> Initializes a new instance of Files. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="keyCredential"> The key credential to copy. </param>
        /// <param name="endpoint"> OpenAI Endpoint. </param>
        internal Files(ClientPipeline pipeline, ApiKeyCredential keyCredential, Uri endpoint)
        {
            _pipeline = pipeline;
            _keyCredential = keyCredential;
            _endpoint = endpoint;
        }

        /// <summary>
        /// Upload a file that can be used across various endpoints. The size of all the files uploaded by
        /// one organization can be up to 100 GB.
        ///
        /// The size of individual files can be a maximum of 512 MB or 2 million tokens for Assistants. See
        /// the [Assistants Tools guide](/docs/assistants/tools) to learn more about the types of files
        /// supported. The Fine-tuning API only supports `.jsonl` files.
        ///
        /// Please [contact us](https://help.openai.com/) if you need to increase these storage limits.
        /// </summary>
        /// <param name="file"> The <see cref="CreateFileRequest"/> to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="file"/> is null. </exception>
        public virtual async Task<ClientResult<OpenAIFile>> CreateFileAsync(CreateFileRequest file, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(file, nameof(file));

            RequestOptions context = FromCancellationToken(cancellationToken);
            using BinaryContent content = file.ToBinaryBody();
            ClientResult result = await CreateFileAsync(content, context).ConfigureAwait(false);
            return ClientResult.FromValue(OpenAIFile.FromResponse(result.GetRawResponse()), result.GetRawResponse());
        }

        /// <summary>
        /// Upload a file that can be used across various endpoints. The size of all the files uploaded by
        /// one organization can be up to 100 GB.
        ///
        /// The size of individual files can be a maximum of 512 MB or 2 million tokens for Assistants. See
        /// the [Assistants Tools guide](/docs/assistants/tools) to learn more about the types of files
        /// supported. The Fine-tuning API only supports `.jsonl` files.
        ///
        /// Please [contact us](https://help.openai.com/) if you need to increase these storage limits.
        /// </summary>
        /// <param name="file"> The <see cref="CreateFileRequest"/> to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="file"/> is null. </exception>
        public virtual ClientResult<OpenAIFile> CreateFile(CreateFileRequest file, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(file, nameof(file));

            RequestOptions context = FromCancellationToken(cancellationToken);
            using BinaryContent content = file.ToBinaryBody();
            ClientResult result = CreateFile(content, context);
            return ClientResult.FromValue(OpenAIFile.FromResponse(result.GetRawResponse()), result.GetRawResponse());
        }

        /// <summary>
        /// [Protocol Method] Upload a file that can be used across various endpoints. The size of all the files uploaded by
        /// one organization can be up to 100 GB.
        ///
        /// The size of individual files can be a maximum of 512 MB or 2 million tokens for Assistants. See
        /// the [Assistants Tools guide](/docs/assistants/tools) to learn more about the types of files
        /// supported. The Fine-tuning API only supports `.jsonl` files.
        ///
        /// Please [contact us](https://help.openai.com/) if you need to increase these storage limits.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Please try the simpler <see cref="CreateFileAsync(CreateFileRequest,CancellationToken)"/> convenience overload with strongly typed models first.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        /// <exception cref="ClientResultException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        public virtual async Task<ClientResult> CreateFileAsync(BinaryContent content, RequestOptions context = null)
        {
            Argument.AssertNotNull(content, nameof(content));

            using PipelineMessage message = CreateCreateFileRequest(content, context);
            return ClientResult.FromResponse(await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false));
        }

        /// <summary>
        /// [Protocol Method] Upload a file that can be used across various endpoints. The size of all the files uploaded by
        /// one organization can be up to 100 GB.
        ///
        /// The size of individual files can be a maximum of 512 MB or 2 million tokens for Assistants. See
        /// the [Assistants Tools guide](/docs/assistants/tools) to learn more about the types of files
        /// supported. The Fine-tuning API only supports `.jsonl` files.
        ///
        /// Please [contact us](https://help.openai.com/) if you need to increase these storage limits.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Please try the simpler <see cref="CreateFile(CreateFileRequest,CancellationToken)"/> convenience overload with strongly typed models first.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        /// <exception cref="ClientResultException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        public virtual ClientResult CreateFile(BinaryContent content, RequestOptions context = null)
        {
            Argument.AssertNotNull(content, nameof(content));

            using PipelineMessage message = CreateCreateFileRequest(content, context);
            return ClientResult.FromResponse(_pipeline.ProcessMessage(message, context));
        }

        /// <summary> Returns a list of files that belong to the user's organization. </summary>
        /// <param name="purpose"> Only return files with the given purpose. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ClientResult<ListFilesResponse>> GetFilesAsync(string purpose = null, CancellationToken cancellationToken = default)
        {
            RequestOptions context = FromCancellationToken(cancellationToken);
            ClientResult result = await GetFilesAsync(purpose, context).ConfigureAwait(false);
            return ClientResult.FromValue(ListFilesResponse.FromResponse(result.GetRawResponse()), result.GetRawResponse());
        }

        /// <summary> Returns a list of files that belong to the user's organization. </summary>
        /// <param name="purpose"> Only return files with the given purpose. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ClientResult<ListFilesResponse> GetFiles(string purpose = null, CancellationToken cancellationToken = default)
        {
            RequestOptions context = FromCancellationToken(cancellationToken);
            ClientResult result = GetFiles(purpose, context);
            return ClientResult.FromValue(ListFilesResponse.FromResponse(result.GetRawResponse()), result.GetRawResponse());
        }

        /// <summary>
        /// [Protocol Method] Returns a list of files that belong to the user's organization.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Please try the simpler <see cref="GetFilesAsync(string,CancellationToken)"/> convenience overload with strongly typed models first.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="purpose"> Only return files with the given purpose. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ClientResultException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        public virtual async Task<ClientResult> GetFilesAsync(string purpose, RequestOptions context)
        {
            using PipelineMessage message = CreateGetFilesRequest(purpose, context);
            return ClientResult.FromResponse(await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false));
        }

        /// <summary>
        /// [Protocol Method] Returns a list of files that belong to the user's organization.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Please try the simpler <see cref="GetFiles(string,CancellationToken)"/> convenience overload with strongly typed models first.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="purpose"> Only return files with the given purpose. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ClientResultException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        public virtual ClientResult GetFiles(string purpose, RequestOptions context)
        {
            using PipelineMessage message = CreateGetFilesRequest(purpose, context);
            return ClientResult.FromResponse(_pipeline.ProcessMessage(message, context));
        }

        /// <summary> Returns information about a specific file. </summary>
        /// <param name="fileId"> The ID of the file to use for this request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="fileId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="fileId"/> is an empty string, and was expected to be non-empty. </exception>
        public virtual async Task<ClientResult<OpenAIFile>> RetrieveFileAsync(string fileId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(fileId, nameof(fileId));

            RequestOptions context = FromCancellationToken(cancellationToken);
            ClientResult result = await RetrieveFileAsync(fileId, context).ConfigureAwait(false);
            return ClientResult.FromValue(OpenAIFile.FromResponse(result.GetRawResponse()), result.GetRawResponse());
        }

        /// <summary> Returns information about a specific file. </summary>
        /// <param name="fileId"> The ID of the file to use for this request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="fileId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="fileId"/> is an empty string, and was expected to be non-empty. </exception>
        public virtual ClientResult<OpenAIFile> RetrieveFile(string fileId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(fileId, nameof(fileId));

            RequestOptions context = FromCancellationToken(cancellationToken);
            ClientResult result = RetrieveFile(fileId, context);
            return ClientResult.FromValue(OpenAIFile.FromResponse(result.GetRawResponse()), result.GetRawResponse());
        }

        /// <summary>
        /// [Protocol Method] Returns information about a specific file.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Please try the simpler <see cref="RetrieveFileAsync(string,CancellationToken)"/> convenience overload with strongly typed models first.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="fileId"> The ID of the file to use for this request. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="fileId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="fileId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ClientResultException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        public virtual async Task<ClientResult> RetrieveFileAsync(string fileId, RequestOptions context)
        {
            Argument.AssertNotNullOrEmpty(fileId, nameof(fileId));

            using PipelineMessage message = CreateRetrieveFileRequest(fileId, context);
            return ClientResult.FromResponse(await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false));
        }

        /// <summary>
        /// [Protocol Method] Returns information about a specific file.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Please try the simpler <see cref="RetrieveFile(string,CancellationToken)"/> convenience overload with strongly typed models first.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="fileId"> The ID of the file to use for this request. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="fileId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="fileId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ClientResultException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        public virtual ClientResult RetrieveFile(string fileId, RequestOptions context)
        {
            Argument.AssertNotNullOrEmpty(fileId, nameof(fileId));

            using PipelineMessage message = CreateRetrieveFileRequest(fileId, context);
            return ClientResult.FromResponse(_pipeline.ProcessMessage(message, context));
        }

        /// <summary> Delete a file. </summary>
        /// <param name="fileId"> The ID of the file to use for this request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="fileId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="fileId"/> is an empty string, and was expected to be non-empty. </exception>
        public virtual async Task<ClientResult<DeleteFileResponse>> DeleteFileAsync(string fileId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(fileId, nameof(fileId));

            RequestOptions context = FromCancellationToken(cancellationToken);
            ClientResult result = await DeleteFileAsync(fileId, context).ConfigureAwait(false);
            return ClientResult.FromValue(DeleteFileResponse.FromResponse(result.GetRawResponse()), result.GetRawResponse());
        }

        /// <summary> Delete a file. </summary>
        /// <param name="fileId"> The ID of the file to use for this request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="fileId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="fileId"/> is an empty string, and was expected to be non-empty. </exception>
        public virtual ClientResult<DeleteFileResponse> DeleteFile(string fileId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(fileId, nameof(fileId));

            RequestOptions context = FromCancellationToken(cancellationToken);
            ClientResult result = DeleteFile(fileId, context);
            return ClientResult.FromValue(DeleteFileResponse.FromResponse(result.GetRawResponse()), result.GetRawResponse());
        }

        /// <summary>
        /// [Protocol Method] Delete a file
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Please try the simpler <see cref="DeleteFileAsync(string,CancellationToken)"/> convenience overload with strongly typed models first.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="fileId"> The ID of the file to use for this request. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="fileId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="fileId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ClientResultException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        public virtual async Task<ClientResult> DeleteFileAsync(string fileId, RequestOptions context)
        {
            Argument.AssertNotNullOrEmpty(fileId, nameof(fileId));

            using PipelineMessage message = CreateDeleteFileRequest(fileId, context);
            return ClientResult.FromResponse(await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false));
        }

        /// <summary>
        /// [Protocol Method] Delete a file
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Please try the simpler <see cref="DeleteFile(string,CancellationToken)"/> convenience overload with strongly typed models first.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="fileId"> The ID of the file to use for this request. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="fileId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="fileId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ClientResultException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        public virtual ClientResult DeleteFile(string fileId, RequestOptions context)
        {
            Argument.AssertNotNullOrEmpty(fileId, nameof(fileId));

            using PipelineMessage message = CreateDeleteFileRequest(fileId, context);
            return ClientResult.FromResponse(_pipeline.ProcessMessage(message, context));
        }

        /// <summary> Returns the contents of the specified file. </summary>
        /// <param name="fileId"> The ID of the file to use for this request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="fileId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="fileId"/> is an empty string, and was expected to be non-empty. </exception>
        public virtual async Task<ClientResult<string>> DownloadFileAsync(string fileId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(fileId, nameof(fileId));

            RequestOptions context = FromCancellationToken(cancellationToken);
            ClientResult result = await DownloadFileAsync(fileId, context).ConfigureAwait(false);
            return ClientResult.FromValue(result.GetRawResponse().Content.ToObjectFromJson<string>(), result.GetRawResponse());
        }

        /// <summary> Returns the contents of the specified file. </summary>
        /// <param name="fileId"> The ID of the file to use for this request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="fileId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="fileId"/> is an empty string, and was expected to be non-empty. </exception>
        public virtual ClientResult<string> DownloadFile(string fileId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(fileId, nameof(fileId));

            RequestOptions context = FromCancellationToken(cancellationToken);
            ClientResult result = DownloadFile(fileId, context);
            return ClientResult.FromValue(result.GetRawResponse().Content.ToObjectFromJson<string>(), result.GetRawResponse());
        }

        /// <summary>
        /// [Protocol Method] Returns the contents of the specified file.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Please try the simpler <see cref="DownloadFileAsync(string,CancellationToken)"/> convenience overload with strongly typed models first.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="fileId"> The ID of the file to use for this request. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="fileId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="fileId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ClientResultException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        public virtual async Task<ClientResult> DownloadFileAsync(string fileId, RequestOptions context)
        {
            Argument.AssertNotNullOrEmpty(fileId, nameof(fileId));

            using PipelineMessage message = CreateDownloadFileRequest(fileId, context);
            return ClientResult.FromResponse(await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false));
        }

        /// <summary>
        /// [Protocol Method] Returns the contents of the specified file.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Please try the simpler <see cref="DownloadFile(string,CancellationToken)"/> convenience overload with strongly typed models first.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="fileId"> The ID of the file to use for this request. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="fileId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="fileId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ClientResultException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        public virtual ClientResult DownloadFile(string fileId, RequestOptions context)
        {
            Argument.AssertNotNullOrEmpty(fileId, nameof(fileId));

            using PipelineMessage message = CreateDownloadFileRequest(fileId, context);
            return ClientResult.FromResponse(_pipeline.ProcessMessage(message, context));
        }

        internal PipelineMessage CreateCreateFileRequest(BinaryContent content, RequestOptions context)
        {
            var message = _pipeline.CreateMessage();
            if (context != null)
            {
                message.Apply(context);
            }
            message.ResponseClassifier = PipelineMessageClassifier200;
            var request = message.Request;
            request.Method = "POST";
            var uri = new ClientUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/files", false);
            request.Uri = uri.ToUri();
            request.Headers.Set("Accept", "application/json");
            request.Headers.Set("content-type", "multipart/form-data");
            request.Content = content;
            return message;
        }

        internal PipelineMessage CreateGetFilesRequest(string purpose, RequestOptions context)
        {
            var message = _pipeline.CreateMessage();
            if (context != null)
            {
                message.Apply(context);
            }
            message.ResponseClassifier = PipelineMessageClassifier200;
            var request = message.Request;
            request.Method = "GET";
            var uri = new ClientUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/files", false);
            if (purpose != null)
            {
                uri.AppendQuery("purpose", purpose, true);
            }
            request.Uri = uri.ToUri();
            request.Headers.Set("Accept", "application/json");
            return message;
        }

        internal PipelineMessage CreateRetrieveFileRequest(string fileId, RequestOptions context)
        {
            var message = _pipeline.CreateMessage();
            if (context != null)
            {
                message.Apply(context);
            }
            message.ResponseClassifier = PipelineMessageClassifier200;
            var request = message.Request;
            request.Method = "GET";
            var uri = new ClientUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/files/", false);
            uri.AppendPath(fileId, true);
            request.Uri = uri.ToUri();
            request.Headers.Set("Accept", "application/json");
            return message;
        }

        internal PipelineMessage CreateDeleteFileRequest(string fileId, RequestOptions context)
        {
            var message = _pipeline.CreateMessage();
            if (context != null)
            {
                message.Apply(context);
            }
            message.ResponseClassifier = PipelineMessageClassifier200;
            var request = message.Request;
            request.Method = "DELETE";
            var uri = new ClientUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/files/", false);
            uri.AppendPath(fileId, true);
            request.Uri = uri.ToUri();
            request.Headers.Set("Accept", "application/json");
            return message;
        }

        internal PipelineMessage CreateDownloadFileRequest(string fileId, RequestOptions context)
        {
            var message = _pipeline.CreateMessage();
            if (context != null)
            {
                message.Apply(context);
            }
            message.ResponseClassifier = PipelineMessageClassifier200;
            var request = message.Request;
            request.Method = "GET";
            var uri = new ClientUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/files/", false);
            uri.AppendPath(fileId, true);
            uri.AppendPath("/content", false);
            request.Uri = uri.ToUri();
            request.Headers.Set("Accept", "application/json");
            return message;
        }

        private static RequestOptions DefaultRequestContext = new RequestOptions();
        internal static RequestOptions FromCancellationToken(CancellationToken cancellationToken = default)
        {
            if (!cancellationToken.CanBeCanceled)
            {
                return DefaultRequestContext;
            }

            return new RequestOptions() { CancellationToken = cancellationToken };
        }

        private static PipelineMessageClassifier _pipelineMessageClassifier200;
        private static PipelineMessageClassifier PipelineMessageClassifier200 => _pipelineMessageClassifier200 ??= PipelineMessageClassifier.Create(stackalloc ushort[] { 200 });
    }
}
