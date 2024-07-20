using Content.Server.Atmos.Piping.Trinary.EntitySystems;
using Content.Shared.Atmos;

namespace Content.Server.Atmos.Piping.Trinary.Components
{
    [RegisterComponent]
    [Access(typeof(GasMixerSystem))]
    public sealed partial class GasMixerComponent : Component
    {
            [DataField("enabled")]
        public bool Enabled = true;

            [DataField("inletOne")]
        public string InletOneName = "inletOne";

            [DataField("inletTwo")]
        public string InletTwoName = "inletTwo";

            [DataField("outlet")]
        public string OutletName = "outlet";

            [DataField("targetPressure")]
        public float TargetPressure = Atmospherics.OneAtmosphere;

            [DataField("maxTargetPressure")]
        public float MaxTargetPressure = Atmospherics.MaxOutputPressure;

            [DataField("inletOneConcentration")]
        public float InletOneConcentration = 0.5f;

            [DataField("inletTwoConcentration")]
        public float InletTwoConcentration = 0.5f;
    }
}
