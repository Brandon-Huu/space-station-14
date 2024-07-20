using Robust.Shared.GameStates;
using Robust.Shared.Serialization.TypeSerializers.Implementations.Custom.Prototype;

namespace Content.Shared.Weapons.Ranged.Components;

[RegisterComponent, NetworkedComponent]
public sealed partial class HitscanBatteryAmmoProviderComponent : BatteryAmmoProviderComponent
{
    [DataField("proto", required: true, customTypeSerializer: typeof(PrototypeIdSerializer<HitscanPrototype>))]
    public string Prototype = default!;
}
