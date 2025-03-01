// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;
using OpenAI;

namespace OpenAI.Audio
{
    public readonly partial struct AudioTranslationFormat : IEquatable<AudioTranslationFormat>
    {
        private readonly string _value;
        private const string JsonValue = "json";
        private const string TextValue = "text";
        private const string SrtValue = "srt";
        private const string VerboseJsonValue = "verbose_json";
        private const string VttValue = "vtt";

        public AudioTranslationFormat(string value)
        {
            Argument.AssertNotNull(value, nameof(value));

            _value = value;
        }

        public static bool operator ==(AudioTranslationFormat left, AudioTranslationFormat right) => left.Equals(right);

        public static bool operator !=(AudioTranslationFormat left, AudioTranslationFormat right) => !left.Equals(right);

        public static implicit operator AudioTranslationFormat(string value) => new AudioTranslationFormat(value);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AudioTranslationFormat other && Equals(other);

        public bool Equals(AudioTranslationFormat other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;

        public override string ToString() => _value;
    }
}
