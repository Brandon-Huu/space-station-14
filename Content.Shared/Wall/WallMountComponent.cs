namespace Content.Shared.Wall;

/// <summary>
///     This component enables an entity to ignore some obstructions for interaction checks.
/// </summary>
/// <remarks>
///     This will only exempt anchored entities that intersect the wall-mount. Additionally, this exemption will apply
///     in a limited arc, providing basic functionality for directional wall mounts.
/// </remarks>
[RegisterComponent]
public sealed partial class WallMountComponent : Component
{
    /// <summary>
    ///     Range of angles for which the exemption applies. Bigger is more permissive.
    /// </summary>
    [DataField]
    public Angle Arc = new(MathF.PI);

    /// <summary>
    ///     The direction in which the exemption arc is facing, relative to the entity's rotation. Defaults to south.
    /// </summary>
    [DataField]
    public Angle Direction = Angle.Zero;
}
