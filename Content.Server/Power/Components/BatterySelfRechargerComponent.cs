namespace Content.Server.Power.Components
{
    /// <summary>
    ///     Self-recharging battery.
    /// </summary>
    [RegisterComponent]
    public sealed partial class BatterySelfRechargerComponent : Component
    {
        public bool AutoRecharge { get; set; }

        public float AutoRechargeRate { get; set; }
    }
}
