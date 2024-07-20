namespace Content.Server.Morgue.Components;

/// <summary>
/// used to track actively cooking crematoriums
/// </summary>
[RegisterComponent]
public sealed partial class ActiveCrematoriumComponent : Component
{
    public float Accumulator = 0;
}
