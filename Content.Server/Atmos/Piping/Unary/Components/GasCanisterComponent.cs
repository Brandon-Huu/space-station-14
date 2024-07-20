using Content.Shared.Atmos;
using Content.Shared.Containers.ItemSlots;
using Robust.Shared.Audio;

namespace Content.Server.Atmos.Piping.Unary.Components
{
    [RegisterComponent]
    public sealed partial class GasCanisterComponent : Component, IGasMixtureHolder
    {
            [DataField("port")]
        public string PortName { get; set; } = "port";

        /// <summary>
        ///     Container name for the gas tank holder.
        /// </summary>
            [DataField("container")]
        public string ContainerName { get; set; } = "tank_slot";

            [DataField]
        public ItemSlot GasTankSlot = new();

            [DataField("gasMixture")]
        public GasMixture Air { get; set; } = new();

        /// <summary>
        ///     Last recorded pressure, for appearance-updating purposes.
        /// </summary>
        public float LastPressure { get; set; } = 0f;

        /// <summary>
        ///     Minimum release pressure possible for the release valve.
        /// </summary>
            [DataField("minReleasePressure")]
        public float MinReleasePressure { get; set; } = Atmospherics.OneAtmosphere / 10;

        /// <summary>
        ///     Maximum release pressure possible for the release valve.
        /// </summary>
            [DataField("maxReleasePressure")]
        public float MaxReleasePressure { get; set; } = Atmospherics.OneAtmosphere * 10;

        /// <summary>
        ///     Valve release pressure.
        /// </summary>
            [DataField("releasePressure")]
        public float ReleasePressure { get; set; } = Atmospherics.OneAtmosphere;

        /// <summary>
        ///     Whether the release valve is open on the canister.
        /// </summary>
            [DataField("releaseValve")]
        public bool ReleaseValve { get; set; } = false;

        [DataField("accessDeniedSound")]
        public SoundSpecifier AccessDeniedSound = new SoundPathSpecifier("/Audio/Machines/custom_deny.ogg");
    }
}
