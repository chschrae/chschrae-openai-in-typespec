namespace OpenAI;

// SSE specification: https://html.spec.whatwg.org/multipage/server-sent-events.html#parsing-an-event-stream
internal enum SseEventFieldType
{
    Event,
    Data,
    Id,
    Retry,
    Ignored
}