using Robust.Shared.Prototypes;
using Robust.Shared.Serialization.TypeSerializers.Implementations.Custom;

namespace Content.Server.Explosion.Components.OnTrigger;

/// <summary>
/// After being triggered applies the specified components and runs triggers again.
/// </summary>
[RegisterComponent, AutoGenerateComponentPause]
public sealed partial class TwoStageTriggerComponent : Component
{
    /// <summary>
    /// How long it takes for the second stage to be triggered.
    /// </summary>
    [DataField]
    public TimeSpan TriggerDelay = TimeSpan.FromSeconds(10);

    /// <summary>
    /// This list of components that will be added for the second trigger.
    /// </summary>
    [DataField("components", required: true)]
    public ComponentRegistry SecondStageComponents = new();

    [DataField(customTypeSerializer: typeof(TimeOffsetSerializer))]
    [AutoPausedField]
    public TimeSpan? NextTriggerTime;

    [DataField]
    public bool Triggered = false;

    [DataField("ComponentsIsLoaded")] //TODO: make camel case
    public bool ComponentsIsLoaded = false;
}
