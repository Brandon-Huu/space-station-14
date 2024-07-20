using Content.Server.Pointing.EntitySystems;
using Content.Shared.Pointing.Components;

namespace Content.Server.Pointing.Components
{
    [RegisterComponent]
    [Access(typeof(RoguePointingSystem))]
    public sealed partial class RoguePointingArrowComponent : SharedRoguePointingArrowComponent
    {
        [ViewVariables]
        public EntityUid? Chasing;

            [DataField("turningDelay")]
        public float TurningDelay = 2;

            [DataField("chasingSpeed")]
        public float ChasingSpeed = 5;

            [DataField("chasingTime")]
        public float ChasingTime = 1;
    }
}
