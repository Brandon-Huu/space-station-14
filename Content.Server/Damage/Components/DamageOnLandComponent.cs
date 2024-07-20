using Content.Shared.Damage;

namespace Content.Server.Damage.Components
{
    [RegisterComponent]
    public sealed partial class DamageOnLandComponent : Component
    {
        [DataField("ignoreResistances")]
            public bool IgnoreResistances = false;

        [DataField("damage", required: true)]
            public DamageSpecifier Damage = default!;
    }
}
