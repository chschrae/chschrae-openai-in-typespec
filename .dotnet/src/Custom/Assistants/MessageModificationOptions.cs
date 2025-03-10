using System.Collections.Generic;

namespace OpenAI.Assistants;

/// <summary>
/// Represents additional options available when modifying an existing <see cref="ThreadMessage"/>.
/// </summary>
public partial class MessageModificationOptions
{
    /// <summary>
    /// A replacement for the optional key/value mapping of additional, supplemental data items to attach to the
    /// <see cref="ThreadMessage"/>. This information may be useful for storing custom details in a structured format.
    /// </summary>
    /// <remarks>
    /// <list type="bullet">
    ///     <item><b>Keys</b> can be a maximum of 64 characters in length.</item>
    ///     <item><b>Values</b> can be a maximum of 512 characters in length.</item>
    /// </list>
    /// </remarks>
    public IDictionary<string, string> Metadata { get; } = new ChangeTrackingDictionary<string, string>();
}