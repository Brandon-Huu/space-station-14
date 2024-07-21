using Content.Shared.Chemistry.Reagent;
using Content.Shared.FixedPoint;

namespace Content.Server.Power.Components;

[RegisterComponent]
public sealed partial class RiggableComponent : Component
{
    [DataField]
    public bool IsRigged;

    [DataField]
    public string Solution = "battery";

    [DataField("reagent")]
    public ReagentQuantity RequiredQuantity = new("Plasma", FixedPoint2.New(5), null);
}
