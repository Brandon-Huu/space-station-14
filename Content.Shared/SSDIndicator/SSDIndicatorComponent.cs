﻿using Content.Shared.StatusIcon;
using Robust.Shared.GameStates;
using Robust.Shared.Prototypes;
using Robust.Shared.Serialization.TypeSerializers.Implementations.Custom.Prototype;

namespace Content.Shared.SSDIndicator;

/// <summary>
///     Shows status icon when player in SSD
/// </summary>
[RegisterComponent, NetworkedComponent]
[AutoGenerateComponentState]
public sealed partial class SSDIndicatorComponent : Component
{
    [AutoNetworkedField]
    public bool IsSSD = true;

    [DataField]
    public ProtoId<StatusIconPrototype> Icon = "SSDIcon";
}
