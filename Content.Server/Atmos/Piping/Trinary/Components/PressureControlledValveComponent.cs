using Content.Shared.Atmos;

namespace Content.Server.Atmos.Piping.Trinary.Components
{
    [RegisterComponent]
    public sealed partial class PressureControlledValveComponent : Component
    {
            [DataField("inlet")]
        public string InletName { get; set; } = "inlet";

            [DataField("control")]
        public string ControlName { get; set; } = "control";

            [DataField("outlet")]
        public string OutletName { get; set; } = "outlet";

        [ViewVariables(VVAccess.ReadOnly)]
        [DataField("enabled")]
        public bool Enabled { get; set; } = false;

            [DataField("gain")]
        public float Gain { get; set; } = 10;

            [DataField("threshold")]
        public float Threshold { get; set; } = Atmospherics.OneAtmosphere;

        [DataField("maxTransferRate")]
        public float MaxTransferRate { get; set; } = Atmospherics.MaxTransferRate;
    }
}
