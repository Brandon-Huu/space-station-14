namespace Content.Shared.Actions.Events;

public sealed partial class FireStarterActionEvent : InstantActionEvent
{
    /// <summary>
    /// Increases the number of fire stacks when a flammable object is ignited.
    /// </summary>
    public float Severity = 0.3f;
}
