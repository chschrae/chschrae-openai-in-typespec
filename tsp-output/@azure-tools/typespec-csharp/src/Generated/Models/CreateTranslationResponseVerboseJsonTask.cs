// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace OpenAI.Models
{
    /// <summary> The CreateTranslationResponseVerboseJson_task. </summary>
    public readonly partial struct CreateTranslationResponseVerboseJsonTask : IEquatable<CreateTranslationResponseVerboseJsonTask>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="CreateTranslationResponseVerboseJsonTask"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public CreateTranslationResponseVerboseJsonTask(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string TranslateValue = "translate";

        /// <summary> translate. </summary>
        public static CreateTranslationResponseVerboseJsonTask Translate { get; } = new CreateTranslationResponseVerboseJsonTask(TranslateValue);
        /// <summary> Determines if two <see cref="CreateTranslationResponseVerboseJsonTask"/> values are the same. </summary>
        public static bool operator ==(CreateTranslationResponseVerboseJsonTask left, CreateTranslationResponseVerboseJsonTask right) => left.Equals(right);
        /// <summary> Determines if two <see cref="CreateTranslationResponseVerboseJsonTask"/> values are not the same. </summary>
        public static bool operator !=(CreateTranslationResponseVerboseJsonTask left, CreateTranslationResponseVerboseJsonTask right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="CreateTranslationResponseVerboseJsonTask"/>. </summary>
        public static implicit operator CreateTranslationResponseVerboseJsonTask(string value) => new CreateTranslationResponseVerboseJsonTask(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is CreateTranslationResponseVerboseJsonTask other && Equals(other);
        /// <inheritdoc />
        public bool Equals(CreateTranslationResponseVerboseJsonTask other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
