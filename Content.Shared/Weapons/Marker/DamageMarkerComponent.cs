using Content.Shared.Damage;
using Robust.Shared.Audio;
using Robust.Shared.GameStates;
using Robust.Shared.Serialization.TypeSerializers.Implementations.Custom;
using Robust.Shared.Utility;

namespace Content.Shared.Weapons.Marker;

/// <summary>
/// Marks an entity to take additional damage
/// </summary>
[RegisterComponent, NetworkedComponent, AutoGenerateComponentState, Access(typeof(SharedDamageMarkerSystem))]
[AutoGenerateComponentPause]
public sealed partial class DamageMarkerComponent : Component
{
    /// <summary>
    /// Sprite to apply to the entity while damagemarker is applied.
    /// </summary>
    [DataField]
    public SpriteSpecifier.Rsi? Effect = new(new ResPath("/Textures/Objects/Weapons/Effects"), "shield2");

    /// <summary>
    /// Sound to play when the damage marker is procced.
    /// </summary>
    [DataField]
    public SoundSpecifier? Sound = new SoundPathSpecifier("/Audio/Weapons/Guns/Gunshots/kinetic_accel.ogg");

    [DataField]
    public DamageSpecifier Damage = new();

    /// <summary>
    /// Entity that marked this entity for a damage surplus.
    /// </summary>
    [AutoNetworkedField]
    public EntityUid Marker;

    [ DataField(customTypeSerializer:typeof(TimeOffsetSerializer)), AutoNetworkedField]
    [AutoPausedField]
    public TimeSpan EndTime;
}
