using Content.Shared.Atmos;

namespace Content.Server.Atmos.Piping.Binary.Components
{
    [RegisterComponent]
    public sealed partial class GasVolumePumpComponent : Component
    {
            [DataField("enabled")]
        public bool Enabled { get; set; } = true;

        [DataField("blocked")]
        public bool Blocked { get; set; } = false;

            public bool Overclocked { get; set; } = false;

            [DataField("inlet")]
        public string InletName { get; set; } = "inlet";

            [DataField("outlet")]
        public string OutletName { get; set; } = "outlet";

            [DataField("transferRate")]
        public float TransferRate { get; set; } = Atmospherics.MaxTransferRate;

            [DataField("maxTransferRate")]
        public float MaxTransferRate { get; set; } = Atmospherics.MaxTransferRate;

        [DataField("leakRatio")]
        public float LeakRatio { get; set; } = 0.1f;

        [DataField("lowerThreshold")]
        public float LowerThreshold { get; set; } = 0.01f;

        [DataField("higherThreshold")]
        public float HigherThreshold { get; set; } = DefaultHigherThreshold;
        public static readonly float DefaultHigherThreshold = 2 * Atmospherics.MaxOutputPressure;

        [DataField("overclockThreshold")]
        public float OverclockThreshold { get; set; } = 1000;

        [DataField("lastMolesTransferred")]
        public float LastMolesTransferred;
    }
}
