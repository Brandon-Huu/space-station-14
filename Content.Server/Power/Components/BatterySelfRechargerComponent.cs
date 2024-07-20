namespace Content.Server.Power.Components
{
    /// <summary>
    ///     Self-recharging battery.
    /// </summary>
    [RegisterComponent]
    public sealed partial class BatterySelfRechargerComponent : Component
    {
        [DataField("autoRecharge")] public bool AutoRecharge { get; set; }

        [DataField("autoRechargeRate")] public float AutoRechargeRate { get; set; }
    }
}
