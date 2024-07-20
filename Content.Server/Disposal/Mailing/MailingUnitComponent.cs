using Content.Shared.Disposal.Components;

namespace Content.Server.Disposal.Mailing;

[Access(typeof(MailingUnitSystem))]
[RegisterComponent]
public sealed partial class MailingUnitComponent : Component
{
    /// <summary>
    /// List of targets the mailing unit can send to.
    /// Each target is just a disposal routing tag
    /// </summary>
    [DataField]
    public List<string> TargetList = new();

    /// <summary>
    /// The target that gets attached to the disposal holders tag list on flush
    /// </summary>
    [DataField]
    public string? Target;

    /// <summary>
    /// The tag for this mailing unit
    /// </summary>
    [DataField]
    public string? Tag;

    public SharedDisposalUnitComponent.DisposalUnitBoundUserInterfaceState? DisposalUnitInterfaceState;
}
