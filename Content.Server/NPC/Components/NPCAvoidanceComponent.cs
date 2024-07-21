namespace Content.Server.NPC.Components;

/// <summary>
/// Should this entity be considered for collision avoidance
/// </summary>
[RegisterComponent]
public sealed partial class NPCAvoidanceComponent : Component
{
    [DataField]
    public bool Enabled = true;
}
