using Content.Shared.Atmos;

namespace Content.Server.Atmos.Piping.Binary.Components
{
    [RegisterComponent]
    public sealed partial class GasPressurePumpComponent : Component
    {
            [DataField("enabled")]
        public bool Enabled { get; set; } = true;

            [DataField("inlet")]
        public string InletName { get; set; } = "inlet";

            [DataField("outlet")]
        public string OutletName { get; set; } = "outlet";

            [DataField("targetPressure")]
        public float TargetPressure { get; set; } = Atmospherics.OneAtmosphere;

        /// <summary>
        ///     Max pressure of the target gas (NOT relative to source).
        /// </summary>
            [DataField("maxTargetPressure")]
        public float MaxTargetPressure = Atmospherics.MaxOutputPressure;
    }
}
