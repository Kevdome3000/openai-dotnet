// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace OpenAI.Assistants
{
    internal readonly partial struct InternalRunStepDetailsToolCallsFileSearchResultObjectContentType : IEquatable<InternalRunStepDetailsToolCallsFileSearchResultObjectContentType>
    {
        private readonly string _value;

        public InternalRunStepDetailsToolCallsFileSearchResultObjectContentType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string TextValue = "text";

        public static InternalRunStepDetailsToolCallsFileSearchResultObjectContentType Text { get; } = new InternalRunStepDetailsToolCallsFileSearchResultObjectContentType(TextValue);
        public static bool operator ==(InternalRunStepDetailsToolCallsFileSearchResultObjectContentType left, InternalRunStepDetailsToolCallsFileSearchResultObjectContentType right) => left.Equals(right);
        public static bool operator !=(InternalRunStepDetailsToolCallsFileSearchResultObjectContentType left, InternalRunStepDetailsToolCallsFileSearchResultObjectContentType right) => !left.Equals(right);
        public static implicit operator InternalRunStepDetailsToolCallsFileSearchResultObjectContentType(string value) => new InternalRunStepDetailsToolCallsFileSearchResultObjectContentType(value);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is InternalRunStepDetailsToolCallsFileSearchResultObjectContentType other && Equals(other);
        public bool Equals(InternalRunStepDetailsToolCallsFileSearchResultObjectContentType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        public override string ToString() => _value;
    }
}
