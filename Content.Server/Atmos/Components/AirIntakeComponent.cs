using Content.Server.Atmos.EntitySystems;
﻿using Content.Shared.Atmos;

namespace Content.Server.Atmos.Components;

/// <summary>
/// This is basically a siphon vent for <see cref="GetFilterAirEvent"/>.
/// </summary>
[RegisterComponent, Access(typeof(AirFilterSystem))]
public sealed partial class AirIntakeComponent : Component
{
    /// <summary>
    /// Target pressure change for a single atmos tick
    /// </summary>
    [DataField]
    public float TargetPressureChange = 5f;

    /// <summary>
    /// How strong the intake pump is, it will be able to replenish air from lower pressure areas.
    /// </summary>
    [DataField]
    public float PumpPower = 2f;

    /// <summary>
    /// Pressure to intake gases up to, maintains pressure of the air volume.
    /// </summary>
    [DataField]
    public float Pressure = Atmospherics.OneAtmosphere;
}
