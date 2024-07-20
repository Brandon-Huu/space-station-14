using Content.Server.Explosion.EntitySystems;
using Robust.Shared.Containers;
using Robust.Shared.Prototypes;

namespace Content.Server.Explosion.Components
{
    [RegisterComponent, Access(typeof(ClusterGrenadeSystem))]
    public sealed partial class ClusterGrenadeComponent : Component
    {
        public Container GrenadesContainer = default!;

        /// <summary>
        ///     What we fill our prototype with if we want to pre-spawn with grenades.
        /// </summary>
        [DataField("fillPrototype")]
        public EntProtoId? FillPrototype;

        /// <summary>
        ///     If we have a pre-fill how many more can we spawn.
        /// </summary>
        public int UnspawnedCount;

        /// <summary>
        ///     Maximum grenades in the container.
        /// </summary>
        [DataField("maxGrenadesCount")]
        public int MaxGrenades = 3;

        /// <summary>
        ///     Maximum delay in seconds between individual grenade triggers
        /// </summary>
            [DataField("grenadeTriggerIntervalMax")]
        public float GrenadeTriggerIntervalMax = 0f;

        /// <summary>
        ///     Minimum delay in seconds between individual grenade triggers
        /// </summary>
            [DataField("grenadeTriggerIntervalMin")]
        public float GrenadeTriggerIntervalMin = 0f;

        /// <summary>
        ///     Minimum delay in seconds before any grenades start to be triggered.
        /// </summary>
            [DataField("baseTriggerDelay")]
        public float BaseTriggerDelay = 1.0f;

        /// <summary>
        ///     Decides if grenades trigger after getting launched
        /// </summary>
        [DataField("triggerGrenades")]
        public bool TriggerGrenades = true;

        /// <summary>
        ///     Does the cluster grenade shoot or throw
        /// </summary>
            [DataField("grenadeType")]
        public Enum GrenadeType = Components.GrenadeType.Throw;

        /// <summary>
        ///     The speed at which grenades get thrown
        /// </summary>
            [DataField("velocity")]
        public float Velocity = 5;

        /// <summary>
        ///     Should the spread be random
        /// </summary>
            [DataField("randomSpread")]
        public bool RandomSpread = false;

        /// <summary>
        ///     Should the angle be random
        /// </summary>
            [DataField("randomAngle")]
        public bool RandomAngle = false;

        /// <summary>
        ///     Static distance grenades will be thrown to.
        /// </summary>
            [DataField("distance")]
        public float Distance = 1f;

        /// <summary>
        ///     Max distance grenades should randomly be thrown to.
        /// </summary>
            [DataField("maxSpreadDistance")]
        public float MaxSpreadDistance = 2.5f;

        /// <summary>
        ///     Minimal distance grenades should randomly be thrown to.
        /// </summary>
            [DataField("minSpreadDistance")]
        public float MinSpreadDistance = 0f;

        /// <summary>
        ///     This is the end.
        /// </summary>
        public bool CountDown;
    }

    public enum GrenadeType
    {
        Throw,
        Shoot
    }

}
