using Content.Shared.Random;
using Robust.Shared.Prototypes;

namespace Content.Shared.Silicons.Laws.Components;

/// <summary>
/// During the ion storm event, this entity will have <see cref="IonStormLawsEvent"/> raised on it if it has laws.
/// New laws can be modified in multiple ways depending on the fields below.
/// </summary>
[RegisterComponent]
public sealed partial class IonStormTargetComponent : Component
{
    /// <summary>
    /// <see cref="WeightedRandomPrototype"/> for a random lawset to possibly replace the old one with.
    /// </summary>
    [DataField]
    public ProtoId<WeightedRandomPrototype> RandomLawsets = "IonStormLawsets";

    /// <summary>
    /// Chance for this borg to be affected at all.
    /// </summary>
    [DataField]
    public float Chance = 0.8f;

    /// <summary>
    /// Chance to replace the lawset with a random one
    /// </summary>
    [DataField]
    public float RandomLawsetChance = 0.25f;

    /// <summary>
    /// Chance to remove a random law.
    /// </summary>
    [DataField]
    public float RemoveChance = 0.2f;

    /// <summary>
    /// Chance to replace a random law with the new one, rather than have it be a glitched-order law.
    /// </summary>
    [DataField]
    public float ReplaceChance = 0.2f;

    /// <summary>
    /// Chance to shuffle laws after everything is done.
    /// </summary>
    [DataField]
    public float ShuffleChance = 0.2f;
}

/// <summary>
/// Raised on an ion storm target to modify its laws.
/// </summary>
[ByRefEvent]
public record struct IonStormLawsEvent(SiliconLawset Lawset);
