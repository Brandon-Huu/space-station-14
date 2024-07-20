using Content.Shared.Light;
using Robust.Shared.Audio;

namespace Content.Client.Light.Visualizers;

[RegisterComponent]
[Access(typeof(PoweredLightVisualizerSystem))]
public sealed partial class PoweredLightVisualsComponent : Component
{
    /// <summary>
    /// A map of the sprite states used by this visualizer indexed by the light state they correspond to.
    /// </summary>
    [DataField("spriteStateMap")]
    [ViewVariables(VVAccess.ReadOnly)]
    public Dictionary<PoweredLightState, string> SpriteStateMap = new()
    {
        [PoweredLightState.Empty] = "empty",
        [PoweredLightState.Off] = "off",
        [PoweredLightState.On] = "on",
        [PoweredLightState.Broken] = "broken",
        [PoweredLightState.Burned] = "burn",
    };

    #region Blinking

    /// <summary>
    /// The id used to track the blinking animation for lights.
    /// </summary>
    [ViewVariables(VVAccess.ReadOnly)]
    public const string BlinkingAnimationKey = "poweredlight_blinking";

    /// <summary>
    /// The minimum length of the base blinking animation (one on-off-on cycle) in seconds.
    /// </summary>
    [DataField("minBlinkingTime")]
    public float MinBlinkingAnimationCycleTime = 0.5f;

    /// <summary>
    /// The maximum length of the base blinking animation (one on-off-on cycle) in seconds.
    /// </summary>
    [DataField("maxBlinkingTime")]
    public float MaxBlinkingAnimationCycleTime = 2;

    /// <summary>
    /// The sound that plays when the blinking animation cycles.
    /// </summary>
    [DataField("blinkingSound")]
    public SoundSpecifier? BlinkingSound = default;

    /// <summary>
    /// Whether or not this light is currently blinking.
    /// </summary>
    public bool IsBlinking;

    #endregion Blinking
}
