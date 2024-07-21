namespace Content.Server.Coordinates;

[RegisterComponent]
public sealed partial class SpawnRandomOffsetComponent : Component
{
    [DataField] public float Offset = 0.5f;
}
