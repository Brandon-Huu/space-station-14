using Content.Server.Physics.Controllers;
using Content.Shared.Physics;
using Robust.Shared.Prototypes;
using Robust.Shared.Serialization.TypeSerializers.Implementations.Custom;

namespace Content.Server.Physics.Components;

/// <summary>
/// A component which makes its entity periodically chaotic jumps arounds
/// </summary>
[RegisterComponent, Access(typeof(ChaoticJumpSystem))]
public sealed partial class ChaoticJumpComponent : Component
{
    /// <summary>
    /// The next moment in time when the entity is pushed toward its goal
    /// </summary>
    [DataField(customTypeSerializer: typeof(TimeOffsetSerializer)), ViewVariables(VVAccess.ReadWrite)]
    public TimeSpan NextJumpTime;

    /// <summary>
    /// Minimum interval between jumps
    /// </summary>
    [DataField]
    public float JumpMinInterval = 5f;
    /// <summary>
    /// Maximum interval between jumps
    /// </summary>
    [DataField]
    public float JumpMaxInterval = 15f;

    /// <summary>
    /// collision limits for which it is impossible to make a jump
    /// </summary>
    [DataField]
    public int CollisionMask = (int) CollisionGroup.Impassable;

    /// <summary>
    /// Minimum jump range
    /// </summary>
    [DataField]
    public float RangeMin = 5f;

    /// <summary>
    /// Maximum jump range
    /// </summary>
    [DataField]
    public float RangeMax = 10f;

    /// <summary>
    /// Spawn before jump
    /// </summary>
    [DataField]
    public EntProtoId Effect = "EffectEmpPulse";
}
