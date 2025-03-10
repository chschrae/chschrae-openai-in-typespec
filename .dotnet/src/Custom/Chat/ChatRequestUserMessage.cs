using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;

namespace OpenAI.Chat;

/// <summary>
/// Represents a chat message of the <c>user</c> role as supplied to a chat completion request. A user message contains
/// information originating from the caller and serves as a prompt for the model to complete. User messages may result
/// in either direct <c>assistant</c> message responses or in calls to supplied <c>tools</c> or <c>functions</c>.
/// </summary>
public class ChatRequestUserMessage : ChatRequestMessage
{
    /// <summary>
    /// An optional <c>name</c> for the participant.
    /// </summary>
    public string ParticipantName { get; init; }

    /// <summary>
    /// Creates a new instance of <see cref="ChatRequestUserMessage"/> with ordinary text <c>content</c>.
    /// </summary>
    /// <param name="content"> The textual content associated with the message. </param>
    public ChatRequestUserMessage(string content)
        : base(ChatRole.User, ChatMessageContent.FromText(content))
    { }

    /// <summary>
    /// Creates a new instance of <see cref="ChatRequestUserMessage"/> using a collection of content items that can
    /// include text and image information. This content format is currently only applicable to the
    /// <c>gpt-4-vision-preview</c> model and will not be accepted by other models.
    /// </summary>
    /// <param name="contentItems">
    ///     The collection of text and image content items associated with the message.
    /// </param>
    public ChatRequestUserMessage(IEnumerable<ChatMessageContent> contentItems)
        : base(ChatRole.User, contentItems.ToArray())
    { }

    /// <summary>
    /// Creates a new instance of <see cref="ChatRequestUserMessage"/> using a collection of content items that can
    /// include text and image information. This content format is currently only applicable to the
    /// <c>gpt-4-vision-preview</c> model and will not be accepted by other models.
    /// </summary>
    /// <param name="contentItems">
    ///     The collection of text and image content items associated with the message.
    /// </param>
    public ChatRequestUserMessage(params ChatMessageContent[] contentItems)
        : this(contentItems as IEnumerable<ChatMessageContent>)
    { }

    internal override void WriteDerivedAdditions(Utf8JsonWriter writer, ModelReaderWriterOptions options)
    {
        if (Optional.IsDefined(ParticipantName))
        {
            writer.WriteString("name"u8, ParticipantName);
        }
    }
}
