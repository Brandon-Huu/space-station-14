namespace Content.Server.NPC.Components
{
    /// Added when a medibot injects someone
    /// So they don't get injected again for at least a minute.
    [RegisterComponent]
    public sealed partial class NPCRecentlyInjectedComponent : Component
    {
        [DataField]
        public float Accumulator = 0f;

        [DataField]
        public TimeSpan RemoveTime = TimeSpan.FromMinutes(1);
    }
}
