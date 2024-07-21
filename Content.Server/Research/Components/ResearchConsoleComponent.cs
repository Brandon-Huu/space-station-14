using Content.Shared.Radio;
using Robust.Shared.Prototypes;

namespace Content.Server.Research.Components;

[RegisterComponent]
public sealed partial class ResearchConsoleComponent : Component
{
    /// <summary>
    /// The radio channel that the unlock announcements are broadcast to.
    /// </summary>
    [DataField]
    public ProtoId<RadioChannelPrototype> AnnouncementChannel = "Science";
}

