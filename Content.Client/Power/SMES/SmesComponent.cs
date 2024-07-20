namespace Content.Client.Power.SMES;

[RegisterComponent]
public sealed partial class SmesComponent : Component
{
    /// <summary>
    /// The prefix used for the RSI states of the sprite layers indicating the charge level of the SMES.
    /// </summary>
    [DataField("chargeOverlayPrefix")]
    public string ChargeOverlayPrefix = "smes-og";

    /// <summary>
    /// The prefix used for the RSI states of the sprite layers indicating the input state of the SMES.
    /// Actually bundled together with the output indicator light.
    /// </summary>
    [DataField("inputOverlayPrefix")]
    public string InputOverlayPrefix = "smes-oc";

    /// <summary>
    /// The prefix used for the RSI states of the sprite layers indicating the output state of the SMES.
    /// Actually bundled together with the input indicator light.
    /// </summary>
    [DataField("outputOverlayPrefix")]
    public string OutputOverlayPrefix = "smes-op";
}
