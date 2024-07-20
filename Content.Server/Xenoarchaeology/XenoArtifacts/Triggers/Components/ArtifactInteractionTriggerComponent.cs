namespace Content.Server.Xenoarchaeology.XenoArtifacts.Triggers.Components;

/// <summary>
///     Activate artifact by touching, attacking or pulling it.
/// </summary>
[RegisterComponent]
public sealed partial class ArtifactInteractionTriggerComponent : Component
{
    /// <summary>
    ///     Should artifact be activated just by touching with empty hand?
    /// </summary>
    [DataField]
    public bool EmptyHandActivation = true;

    /// <summary>
    ///     Should artifact be activated by melee attacking?
    /// </summary>
    [DataField]
    public bool AttackActivation = true;

    /// <summary>
    ///     Should artifact be activated by starting pulling it?
    /// </summary>
    [DataField]
    public bool PullActivation = true;
}
