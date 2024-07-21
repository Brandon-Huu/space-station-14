using Content.Shared.Speech;
using Robust.Shared.Prototypes;

namespace Content.Server.VoiceMask;

[RegisterComponent]
public sealed partial class VoiceMaskComponent : Component
{
    [DataField]
    public bool Enabled = true;

    [DataField]
    public string VoiceName = "Unknown";

    /// <summary>
    /// If EnableSpeechVerbModification is true, overrides the speech verb used when this entity speaks.
    /// </summary>
    [DataField]
    public ProtoId<SpeechVerbPrototype>? SpeechVerb;
}
