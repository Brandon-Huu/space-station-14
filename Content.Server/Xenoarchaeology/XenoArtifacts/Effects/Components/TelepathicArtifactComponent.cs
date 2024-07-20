namespace Content.Server.Xenoarchaeology.XenoArtifacts.Effects.Components;

/// <summary>
///     Harmless artifact that broadcast "thoughts" to players nearby.
///     Thoughts are shown as popups and unique for each player.
/// </summary>
[RegisterComponent]
public sealed partial class TelepathicArtifactComponent : Component
{
    /// <summary>
    ///     Loc string ids of telepathic messages.
    ///     Will be randomly picked and shown to player.
    /// </summary>
    [DataField("messages")]
    public List<string> Messages = default!;

    /// <summary>
    ///     Loc string ids of telepathic messages (spooky version).
    ///     Will be randomly picked and shown to player.
    /// </summary>
    [DataField("drastic")]
    public List<string>? DrasticMessages;

    /// <summary>
    ///     Probability to pick drastic version of message.
    /// </summary>
    [DataField("drasticProb")]
    public float DrasticMessageProb = 0.2f;

    /// <summary>
    ///     Radius in which player can receive artifacts messages.
    /// </summary>
    [DataField("range")]
    public float Range = 10f;
}
