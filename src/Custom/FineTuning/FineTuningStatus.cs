using Microsoft.TypeSpec.Generator.Customizations;
using System;

namespace OpenAI.FineTuning;

[CodeGenType("FineTuningJobStatus")]
public readonly partial struct FineTuningStatus : IEquatable<string>
{
    public bool InProgress =>
        _value == ValidatingFiles ||
        _value == Queued ||
        _value == Running;

    public bool Equals(string other)
    {
        return string.Equals(_value.ToString(), other);
    }
}
