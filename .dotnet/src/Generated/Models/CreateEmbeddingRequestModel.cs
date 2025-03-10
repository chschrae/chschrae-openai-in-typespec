// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace OpenAI.Internal.Models
{
    /// <summary> The CreateEmbeddingRequestModel. </summary>
    internal readonly partial struct CreateEmbeddingRequestModel : IEquatable<CreateEmbeddingRequestModel>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="CreateEmbeddingRequestModel"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public CreateEmbeddingRequestModel(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string TextEmbeddingAda002Value = "text-embedding-ada-002";
        private const string TextEmbedding3SmallValue = "text-embedding-3-small";
        private const string TextEmbedding3LargeValue = "text-embedding-3-large";

        /// <summary> text-embedding-ada-002. </summary>
        public static CreateEmbeddingRequestModel TextEmbeddingAda002 { get; } = new CreateEmbeddingRequestModel(TextEmbeddingAda002Value);
        /// <summary> text-embedding-3-small. </summary>
        public static CreateEmbeddingRequestModel TextEmbedding3Small { get; } = new CreateEmbeddingRequestModel(TextEmbedding3SmallValue);
        /// <summary> text-embedding-3-large. </summary>
        public static CreateEmbeddingRequestModel TextEmbedding3Large { get; } = new CreateEmbeddingRequestModel(TextEmbedding3LargeValue);
        /// <summary> Determines if two <see cref="CreateEmbeddingRequestModel"/> values are the same. </summary>
        public static bool operator ==(CreateEmbeddingRequestModel left, CreateEmbeddingRequestModel right) => left.Equals(right);
        /// <summary> Determines if two <see cref="CreateEmbeddingRequestModel"/> values are not the same. </summary>
        public static bool operator !=(CreateEmbeddingRequestModel left, CreateEmbeddingRequestModel right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="CreateEmbeddingRequestModel"/>. </summary>
        public static implicit operator CreateEmbeddingRequestModel(string value) => new CreateEmbeddingRequestModel(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is CreateEmbeddingRequestModel other && Equals(other);
        /// <inheritdoc />
        public bool Equals(CreateEmbeddingRequestModel other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
