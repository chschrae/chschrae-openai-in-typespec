
#nullable enable

using System.ClientModel;
using System.ClientModel.Primitives;
using System.Threading.Tasks;

namespace OpenAI
{
    internal static class ClientPipelineExtensions
    {
        public static async ValueTask<PipelineResponse> ProcessMessageAsync(this ClientPipeline pipeline, PipelineMessage message, RequestOptions options)
        {
            await pipeline.SendAsync(message).ConfigureAwait(false);

            if (message.Response!.IsError && options.ErrorOptions == ClientErrorBehaviors.Default)
            {
                throw await ClientResultException.CreateAsync(message.Response).ConfigureAwait(false);
            }

            return message.Response;
        }

        public static PipelineResponse ProcessMessage(this ClientPipeline pipeline, PipelineMessage message, RequestOptions options)
        {
            pipeline.Send(message);

            if (message.Response!.IsError && options.ErrorOptions == ClientErrorBehaviors.Default)
            {
                throw new ClientResultException(message.Response);
            }

            return message.Response;
        }

        public static async ValueTask<ClientResult<bool>> ProcessHeadAsBoolMessageAsync(this ClientPipeline pipeline, PipelineMessage message, RequestOptions requestContext)
        {
            PipelineResponse response = await pipeline.ProcessMessageAsync(message, requestContext).ConfigureAwait(false);
            switch (response.Status)
            {
                case >= 200 and < 300:
                    return ClientResult.FromValue(true, response);
                case >= 400 and < 500:
                    return ClientResult.FromValue(false, response);
                default:
                    return new ErrorResult<bool>(response, new ClientResultException(response));
            }
        }

        public static ClientResult<bool> ProcessHeadAsBoolMessage(this ClientPipeline pipeline, PipelineMessage message, RequestOptions requestContext)
        {
            PipelineResponse response = pipeline.ProcessMessage(message, requestContext);
            switch (response.Status)
            {
                case >= 200 and < 300:
                    return ClientResult.FromValue(true, response);
                case >= 400 and < 500:
                    return ClientResult.FromValue(false, response);
                default:
                    return new ErrorResult<bool>(response, new ClientResultException(response));
            }
        }
    }
}
