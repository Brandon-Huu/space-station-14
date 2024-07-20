namespace Content.Server.Power.Components
{
    [RegisterComponent]
    public sealed partial class CableVisComponent : Component
    {
            [DataField("node", required:true)]
        public string Node;
    }
}
