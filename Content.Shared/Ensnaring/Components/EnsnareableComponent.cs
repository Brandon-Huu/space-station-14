using Content.Shared.Alert;
using Robust.Shared.Containers;
using Robust.Shared.GameStates;
using Robust.Shared.Prototypes;
using Robust.Shared.Serialization;

namespace Content.Shared.Ensnaring.Components;
/// <summary>
/// Use this on an entity that you would like to be ensnared by anything that has the <see cref="EnsnaringComponent"/>
/// </summary>
[RegisterComponent, NetworkedComponent]
public sealed partial class EnsnareableComponent : Component
{
    /// <summary>
    /// How much should this slow down the entities walk?
    /// </summary>
    [DataField]
    public float WalkSpeed = 1.0f;

    /// <summary>
    /// How much should this slow down the entities sprint?
    /// </summary>
    [DataField]
    public float SprintSpeed = 1.0f;

    /// <summary>
    /// Is this entity currently ensnared?
    /// </summary>
    [DataField]
    public bool IsEnsnared;

    /// <summary>
    /// The container where the <see cref="EnsnaringComponent"/> entity will be stored
    /// </summary>
    public Container Container = default!;

    [DataField]
    public string? Sprite;

    [DataField]
    public string? State;

    [DataField]
    public ProtoId<AlertPrototype> EnsnaredAlert = "Ensnared";
}

[Serializable, NetSerializable]
public sealed class EnsnareableComponentState : ComponentState
{
    public readonly bool IsEnsnared;

    public EnsnareableComponentState(bool isEnsnared)
    {
        IsEnsnared = isEnsnared;
    }
}

public sealed class EnsnaredChangedEvent : EntityEventArgs
{
    public readonly bool IsEnsnared;

    public EnsnaredChangedEvent(bool isEnsnared)
    {
        IsEnsnared = isEnsnared;
    }
}
