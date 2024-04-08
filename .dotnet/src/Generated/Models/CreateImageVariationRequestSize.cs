// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace OpenAI.Internal.Models
{
    /// <summary> Enum for size in CreateImageVariationRequest. </summary>
    internal readonly partial struct CreateImageVariationRequestSize : IEquatable<CreateImageVariationRequestSize>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="CreateImageVariationRequestSize"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public CreateImageVariationRequestSize(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string _256x256Value = "256x256";
        private const string _512x512Value = "512x512";
        private const string _1024x1024Value = "1024x1024";

        /// <summary> 256x256. </summary>
        public static CreateImageVariationRequestSize _256x256 { get; } = new CreateImageVariationRequestSize(_256x256Value);
        /// <summary> 512x512. </summary>
        public static CreateImageVariationRequestSize _512x512 { get; } = new CreateImageVariationRequestSize(_512x512Value);
        /// <summary> 1024x1024. </summary>
        public static CreateImageVariationRequestSize _1024x1024 { get; } = new CreateImageVariationRequestSize(_1024x1024Value);
        /// <summary> Determines if two <see cref="CreateImageVariationRequestSize"/> values are the same. </summary>
        public static bool operator ==(CreateImageVariationRequestSize left, CreateImageVariationRequestSize right) => left.Equals(right);
        /// <summary> Determines if two <see cref="CreateImageVariationRequestSize"/> values are not the same. </summary>
        public static bool operator !=(CreateImageVariationRequestSize left, CreateImageVariationRequestSize right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="CreateImageVariationRequestSize"/>. </summary>
        public static implicit operator CreateImageVariationRequestSize(string value) => new CreateImageVariationRequestSize(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is CreateImageVariationRequestSize other && Equals(other);
        /// <inheritdoc />
        public bool Equals(CreateImageVariationRequestSize other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
