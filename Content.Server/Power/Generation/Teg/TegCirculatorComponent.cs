﻿using Content.Shared.Atmos;

namespace Content.Server.Power.Generation.Teg;

/// <summary>
/// A "circulator" for the thermo-electric generator (TEG).
/// Circulators are used by the TEG to take in a side of either hot or cold gas.
/// </summary>
/// <seealso cref="TegSystem"/>
[RegisterComponent]
[Access(typeof(TegSystem))]
public sealed partial class TegCirculatorComponent : Component
{
    /// <summary>
    /// The difference between the inlet and outlet pressure at the start of the previous tick.
    /// </summary>
    [DataField]
    public float LastPressureDelta;

    /// <summary>
    /// The amount of moles transferred by the circulator last tick.
    /// </summary>
    [DataField]
    public float LastMolesTransferred;

    /// <summary>
    /// Minimum pressure delta between inlet and outlet for which the circulator animation speed is "fast".
    /// </summary>
    [DataField]
    public float VisualSpeedDelta = 5 * Atmospherics.OneAtmosphere;

    /// <summary>
    /// Light color of this circulator when it's running at "slow" speed.
    /// </summary>
    [DataField]
    public Color LightColorSlow = Color.FromHex("#FF3300");

    /// <summary>
    /// Light color of this circulator when it's running at "fast" speed.
    /// </summary>
    [DataField]
    public Color LightColorFast = Color.FromHex("#AA00FF");
}
