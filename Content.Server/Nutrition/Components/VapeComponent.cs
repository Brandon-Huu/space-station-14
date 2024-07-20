using Content.Server.Nutrition.EntitySystems;
using Content.Shared.Damage;
using Content.Shared.Atmos;

namespace Content.Server.Nutrition.Components // Vapes are very nutritious.
{
    [RegisterComponent, Access(typeof(SmokingSystem))]
    public sealed partial class VapeComponent : Component
    {
        [DataField("delay")]
            public float Delay { get; set; } = 5;

        [DataField("userDelay")]
            public float UserDelay { get; set; } = 2;

        [DataField("explosionIntensity")]
            public float ExplosionIntensity { get; set; } = 2.5f;

        // TODO use RiggableComponent.
        [DataField("explodeOnUse")]
            public bool ExplodeOnUse { get; set; } = false;

        [DataField("damage", required: true)]
            public DamageSpecifier Damage = default!;

        [DataField("gasType")]
            public Gas GasType { get; set; } = Gas.WaterVapor;

        /// <summary>
        /// Solution volume will be divided by this number and converted to the gas
        /// </summary>
        [DataField("reductionFactor")]
            public float ReductionFactor { get; set; } = 300f;

        // TODO when this gets fixed, use prototype serializers
        [DataField("solutionNeeded")]
            public string SolutionNeeded = "Water";
    }
}
