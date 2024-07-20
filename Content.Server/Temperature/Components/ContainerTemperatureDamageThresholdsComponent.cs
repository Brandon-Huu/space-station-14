namespace Content.Server.Temperature.Components;

[RegisterComponent]
public sealed partial class ContainerTemperatureDamageThresholdsComponent: Component
{
    [DataField]
    public float? HeatDamageThreshold;

    [DataField]
    public float? ColdDamageThreshold;
}
