using System.Numerics;
using Robust.Shared.GameStates;

namespace Content.Shared.Jittering;

[Access(typeof(SharedJitteringSystem))]
[RegisterComponent, NetworkedComponent, AutoGenerateComponentState]
public sealed partial class JitteringComponent : Component
{
    [AutoNetworkedField]
    public float Amplitude { get; set; }

    [AutoNetworkedField]
    public float Frequency { get; set; }

    public Vector2 LastJitter { get; set; }

    /// <summary>
    ///     The offset that an entity had before jittering started,
    ///     so that we can reset it properly.
    /// </summary>
    public Vector2 StartOffset = Vector2.Zero;
}
