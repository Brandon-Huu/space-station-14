namespace Content.Server.Atmos.Piping.Components
{
    [RegisterComponent]
    public sealed partial class AtmosUnsafeUnanchorComponent : Component
    {
            [DataField("enabled")]
        public bool Enabled { get; set; } = true;
    }
}
