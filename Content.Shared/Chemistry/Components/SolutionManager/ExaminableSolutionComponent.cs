namespace Content.Shared.Chemistry.Components.SolutionManager;

[RegisterComponent]
public sealed partial class ExaminableSolutionComponent : Component
{
    [DataField]
    public string Solution = "default";

    /// <summary>
    /// If false then the hidden solution is always visible.
    /// </summary>
    [DataField]
    public bool HeldOnly;
}
