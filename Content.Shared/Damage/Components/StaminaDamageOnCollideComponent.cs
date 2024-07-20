using Robust.Shared.Audio;

namespace Content.Shared.Damage.Components;

/// <summary>
/// Applies stamina damage when colliding with an entity.
/// </summary>
[RegisterComponent]
public sealed partial class StaminaDamageOnCollideComponent : Component
{
    [DataField]
    public float Damage = 55f;

    [DataField]
    public SoundSpecifier? Sound;
}
