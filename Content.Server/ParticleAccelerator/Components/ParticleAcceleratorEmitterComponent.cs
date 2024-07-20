using Content.Shared.Singularity.Components;

namespace Content.Server.ParticleAccelerator.Components;

[RegisterComponent]
public sealed partial class ParticleAcceleratorEmitterComponent : Component
{
    [DataField("emittedPrototype")]
    public string EmittedPrototype = "ParticlesProjectile";

    [DataField("emitterType")]
    public ParticleAcceleratorEmitterType Type = ParticleAcceleratorEmitterType.Fore;

    public override string ToString()
    {
        return base.ToString() + $" EmitterType:{Type}";
    }
}

public enum ParticleAcceleratorEmitterType
{
    Port,
    Fore,
    Starboard
}
