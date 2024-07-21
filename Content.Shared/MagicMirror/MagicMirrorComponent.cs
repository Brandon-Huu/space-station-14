using Content.Shared.DoAfter;
using Robust.Shared.Audio;
using Robust.Shared.GameStates;

namespace Content.Shared.MagicMirror;

/// <summary>
/// Allows humanoids to change their appearance mid-round.
/// </summary>
[RegisterComponent, NetworkedComponent, AutoGenerateComponentState]
public sealed partial class MagicMirrorComponent : Component
{
    [DataField]
    public DoAfterId? DoAfter;

    /// <summary>
    /// Magic mirror target, used for validating UI messages.
    /// </summary>
    [DataField, AutoNetworkedField]
    public EntityUid? Target;

    /// <summary>
    /// doafter time required to add a new slot
    /// </summary>
    [DataField]
    public TimeSpan AddSlotTime = TimeSpan.FromSeconds(5);

    /// <summary>
    /// doafter time required to remove a existing slot
    /// </summary>
    [DataField]
    public TimeSpan RemoveSlotTime = TimeSpan.FromSeconds(2);

    /// <summary>
    /// doafter time required to change slot
    /// </summary>
    [DataField]
    public TimeSpan SelectSlotTime = TimeSpan.FromSeconds(3);

    /// <summary>
    /// doafter time required to recolor slot
    /// </summary>
    [DataField]
    public TimeSpan ChangeSlotTime = TimeSpan.FromSeconds(1);

    /// <summary>
    /// Sound emitted when slots are changed
    /// </summary>
    [DataField]
    public SoundSpecifier? ChangeHairSound = new SoundPathSpecifier("/Audio/Items/scissors.ogg");
}
