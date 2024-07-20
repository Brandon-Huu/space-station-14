using Content.Shared.Atmos;

namespace Content.Server.Atmos.Piping.Trinary.Components
{
    [RegisterComponent]
    public sealed partial class GasFilterComponent : Component
    {
            [DataField("enabled")]
        public bool Enabled { get; set; } = true;

            [DataField("inlet")]
        public string InletName { get; set; } = "inlet";

            [DataField("filter")]
        public string FilterName { get; set; } = "filter";

            [DataField("outlet")]
        public string OutletName { get; set; } = "outlet";

    
        [DataField("transferRate")]
        public float TransferRate { get; set; } = Atmospherics.MaxTransferRate;

        [DataField("maxTransferRate")]
        public float MaxTransferRate { get; set; } = Atmospherics.MaxTransferRate;

            public Gas? FilteredGas { get; set; }
    }
}
