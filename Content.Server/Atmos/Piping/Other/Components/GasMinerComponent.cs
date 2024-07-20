using Content.Shared.Atmos;

namespace Content.Server.Atmos.Piping.Other.Components
{
    [RegisterComponent]
    public sealed partial class GasMinerComponent : Component
    {
            public bool Enabled { get; set; } = true;

        [ViewVariables(VVAccess.ReadOnly)]
        public bool Idle { get; set; } = false;

        /// <summary>
        ///      If the number of moles in the external environment exceeds this number, no gas will be mined.
        /// </summary>
            [DataField("maxExternalAmount")]
        public float MaxExternalAmount { get; set; } = float.PositiveInfinity;

        /// <summary>
        ///      If the pressure (in kPA) of the external environment exceeds this number, no gas will be mined.
        /// </summary>
            [DataField("maxExternalPressure")]
        public float MaxExternalPressure { get; set; } = Atmospherics.GasMinerDefaultMaxExternalPressure;

            [DataField("spawnGas")]
        public Gas? SpawnGas { get; set; } = null;

            [DataField("spawnTemperature")]
        public float SpawnTemperature { get; set; } = Atmospherics.T20C;

        /// <summary>
        ///     Number of moles created per second when the miner is working.
        /// </summary>
            [DataField("spawnAmount")]
        public float SpawnAmount { get; set; } = Atmospherics.MolesCellStandard * 20f;
    }
}
