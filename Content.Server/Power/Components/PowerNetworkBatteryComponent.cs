using Content.Server.Power.Pow3r;

namespace Content.Server.Power.Components
{
    /// <summary>
    ///     Glue component that manages the pow3r network node for batteries that are connected to the power network.
    /// </summary>
    /// <remarks>
    ///     This needs components like <see cref="BatteryChargerComponent"/> to work correctly,
    ///     and battery storage should be handed off to components like <see cref="BatteryComponent"/>.
    /// </remarks>
    [RegisterComponent]
    public sealed partial class PowerNetworkBatteryComponent : Component
    {
        [ViewVariables] public float LastSupply = 0f;

        [DataField("maxChargeRate")]
            public float MaxChargeRate
        {
            get => NetworkBattery.MaxChargeRate;
            set => NetworkBattery.MaxChargeRate = value;
        }

        [DataField("maxSupply")]
            public float MaxSupply
        {
            get => NetworkBattery.MaxSupply;
            set => NetworkBattery.MaxSupply = value;
        }

        [DataField("supplyRampTolerance")]
            public float SupplyRampTolerance
        {
            get => NetworkBattery.SupplyRampTolerance;
            set => NetworkBattery.SupplyRampTolerance = value;
        }

        [DataField("supplyRampRate")]
            public float SupplyRampRate
        {
            get => NetworkBattery.SupplyRampRate;
            set => NetworkBattery.SupplyRampRate = value;
        }

        [DataField("supplyRampPosition")]
            public float SupplyRampPosition
        {
            get => NetworkBattery.SupplyRampPosition;
            set => NetworkBattery.SupplyRampPosition = value;
        }

        [DataField("currentSupply")]
            public float CurrentSupply
        {
            get => NetworkBattery.CurrentSupply;
            set => NetworkBattery.CurrentSupply = value;
        }

        [DataField("currentReceiving")]
            public float CurrentReceiving
        {
            get => NetworkBattery.CurrentReceiving;
            set => NetworkBattery.CurrentReceiving = value;
        }

        [DataField("loadingNetworkDemand")]
            public float LoadingNetworkDemand
        {
            get => NetworkBattery.LoadingNetworkDemand;
            set => NetworkBattery.LoadingNetworkDemand = value;
        }

        [DataField("enabled")]
            public bool Enabled
        {
            get => NetworkBattery.Enabled;
            set => NetworkBattery.Enabled = value;
        }

        [DataField("canCharge")]
            public bool CanCharge
        {
            get => NetworkBattery.CanCharge;
            set => NetworkBattery.CanCharge = value;
        }

        [DataField("canDischarge")]
            public bool CanDischarge
        {
            get => NetworkBattery.CanDischarge;
            set => NetworkBattery.CanDischarge = value;
        }

        [DataField("efficiency")]
            public float Efficiency
        {
            get => NetworkBattery.Efficiency;
            set => NetworkBattery.Efficiency = value;
        }

        [ViewVariables]
        public PowerState.Battery NetworkBattery { get; } = new();
    }
}
