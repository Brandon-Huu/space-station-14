namespace Content.Server.Atmos.Piping.Unary.Components
{
    [RegisterComponent]
    public sealed partial class GasPortableComponent : Component
    {
            [DataField("port")]
        public string PortName { get; set; } = "port";
    }
}
