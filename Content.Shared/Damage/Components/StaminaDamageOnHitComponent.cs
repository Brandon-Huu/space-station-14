using Robust.Shared.Audio;

namespace Content.Shared.Damage.Components;

[RegisterComponent]
public sealed partial class StaminaDamageOnHitComponent : Component
{
    [DataField]
    public float Damage = 30f;

    [DataField]
    public SoundSpecifier? Sound;
}
