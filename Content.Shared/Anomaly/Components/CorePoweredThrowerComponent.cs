using System.Numerics;
using Content.Shared.Weapons.Melee.Components;
using Robust.Shared.GameStates;

namespace Content.Shared.Anomaly.Components;

/// <summary>
/// This is used for an entity with <see cref="MeleeThrowOnHitComponent"/> that is governed by an anomaly core inside of it.
/// </summary>
[RegisterComponent, NetworkedComponent]
[Access(typeof(SharedAnomalyCoreSystem))]
public sealed partial class CorePoweredThrowerComponent : Component
{
    /// <summary>
    /// The ID of the item slot containing the core.
    /// </summary>
    [DataField]
    public string CoreSlotId = "core_slot";

    /// <summary>
    /// A range for how much the stability variable on the anomaly will increase with each throw.
    /// </summary>
    [DataField]
    public Vector2 StabilityPerThrow = new(0.1f, 0.2f);
}
