namespace Content.Client.Lock.Visualizers;

[RegisterComponent]
[Access(typeof(LockVisualizerSystem))]
public sealed partial class LockVisualsComponent : Component
{
    /// <summary>
    /// The RSI state used for the lock indicator while the entity is locked.
    /// </summary>
    [DataField("stateLocked")]
    public string? StateLocked = "locked";

    /// <summary>
    /// The RSI state used for the lock indicator entity is unlocked.
    /// </summary>
    [DataField("stateUnlocked")]
    public string? StateUnlocked = "unlocked";
}
