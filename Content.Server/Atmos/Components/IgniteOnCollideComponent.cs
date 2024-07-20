using Content.Server.Atmos.EntitySystems;

namespace Content.Server.Atmos.Components;

[RegisterComponent, Access(typeof(FlammableSystem))]
public sealed partial class IgniteOnCollideComponent : Component
{
    /// <summary>
    /// How many more times the ignition can be applied.
    /// </summary>
    [DataField]
    public int Count = 1;

    [ DataField]
    public float FireStacks;

    [DataField]
    public string FixtureId = "ignition";

}
