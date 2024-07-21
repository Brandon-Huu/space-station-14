using Robust.Shared.GameStates;

namespace Content.Shared.Anomaly.Effects.Components;

[RegisterComponent, NetworkedComponent, Access(typeof(SharedGravityAnomalySystem))]
public sealed partial class GravityAnomalyComponent : Component
{
    /// <summary>
    /// The maximumum size the GravityWellComponent MaxRange can be.
    /// Is scaled linearly with stability.
    /// </summary>
    [DataField]
    public float MaxGravityWellRange = 10f;

    /// <summary>
    /// The maximum distance from which the anomaly
    /// can throw you via a pulse.
    /// </summary>
    [DataField]
    public float MaxThrowRange = 5f;

    /// <summary>
    /// The maximum strength the anomaly
    /// can throw you via a pulse
    /// </summary>
    [DataField]
    public float MaxThrowStrength = 10;

    /// <summary>
    /// The maximum Intensity of the RadiationSourceComponent.
    /// Is scaled linearly with stability.
    /// </summary>
    [DataField]
    public float MaxRadiationIntensity = 3f;

    /// <summary>
    /// The minimum acceleration value for GravityWellComponent
    /// Is scaled linearly with stability.
    /// </summary>
    [DataField]
    public float MinAccel = 0f;

    /// <summary>
    /// The maximum acceleration value for GravityWellComponent
    /// Is scaled linearly with stability.
    /// </summary>
    [DataField]
    public float MaxAccel = 5f;

    /// <summary>
    /// The minimum acceleration value for GravityWellComponent
    /// Is scaled linearly with stability.
    /// </summary>
    [DataField]
    public float MinRadialAccel = 0f;

    /// <summary>
    /// The maximum acceleration value for GravityWellComponent
    /// Is scaled linearly with stability.
    /// </summary>
    [DataField]
    public float MaxRadialAccel = 5f;

    /// <summary>
    /// The maximum speed for RandomWalkComponent
    /// Is scaled linearly with severity.
    /// </summary>
    [DataField]
    public float MinSpeed = 0.1f;

    /// <summary>
    /// The maximum speed for RandomWalkComponent
    /// Is scaled linearly with severity.
    /// </summary>
    [DataField]
    public float MaxSpeed = 1.0f;

    /// <summary>
    /// Random +- speed modifier
    /// </summary>
    [DataField]
    public float SpeedVariation = 0.1f;

    /// <summary>
    /// The range around the anomaly that will be spaced on supercritical.
    /// </summary>
    [DataField]
    public float SpaceRange = 3f;
}
