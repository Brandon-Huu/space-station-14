using Robust.Shared.Audio;

namespace Content.Shared.Atmos.Components;
/// <summary>
/// Allows you to extinguish an object by interacting with it
/// </summary>
[RegisterComponent]
public sealed partial class ExtinguishOnInteractComponent : Component
{
    [DataField]
    public SoundSpecifier? ExtinguishAttemptSound = new SoundPathSpecifier("/Audio/Items/candle_blowing.ogg");

    /// <summary>
    /// Extinguishing chance
    /// </summary>
    [DataField]
    public float Probability = 0.9f;

    /// <summary>
    /// Number of fire stacks to be changed on successful interaction.
    /// </summary>
    // With positive values, the interaction will conversely fan the fire,
    // which is useful for any blacksmithing mechs
    [DataField]
    public float StackDelta = -5.0f;

    [DataField]
    public LocId ExtinguishFailed = "candle-extinguish-failed";
}
