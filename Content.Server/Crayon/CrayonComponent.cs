using Content.Server.UserInterface;
using Content.Shared.Crayon;
using Robust.Server.GameObjects;
using Robust.Shared.Audio;

namespace Content.Server.Crayon
{
    [RegisterComponent]
    public sealed partial class CrayonComponent : SharedCrayonComponent
    {
        [DataField("useSound")] public SoundSpecifier? UseSound;

            [DataField("selectableColor")]
        public bool SelectableColor { get; set; }

            public int Charges { get; set; }

            [DataField("capacity")]
        public int Capacity { get; set; } = 30;

            [DataField("deleteEmpty")]
        public bool DeleteEmpty = true;
    }
}
