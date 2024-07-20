using Robust.Shared.Prototypes;

namespace Content.Server.Spawners.Components
{
    [RegisterComponent, EntityCategory("Spawner")]
    [Virtual]
    public partial class ConditionalSpawnerComponent : Component
    {
            [DataField]
        public List<EntProtoId> Prototypes { get; set; } = new();

            [DataField]
        public List<EntProtoId> GameRules = new();

            [DataField]
        public float Chance { get; set; } = 1.0f;
    }
}
