using Content.Shared.Damage;


// Damages the held item by a set amount when it hits someone. Can be used to make melee items limited-use.
namespace Content.Server.Damage.Components;

[RegisterComponent]
public sealed partial class DamageOnHitComponent : Component
{
    [DataField]
    public bool IgnoreResistances = true;

    [DataField(required: true)]
    public DamageSpecifier Damage = default!;
}

