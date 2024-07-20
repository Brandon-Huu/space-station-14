using Robust.Shared.Prototypes;

namespace Content.Server.Spawners.Components
{
    [RegisterComponent, EntityCategory("Spawner")]
    public sealed partial class RandomSpawnerComponent : ConditionalSpawnerComponent
    {
            [DataField]
        public List<EntProtoId> RarePrototypes { get; set; } = new();

            [DataField]
        public float RareChance { get; set; } = 0.05f;

            [DataField]
        public float Offset { get; set; } = 0.2f;

        [DataField]
        public bool DeleteSpawnerAfterSpawn = true;
    }
}
