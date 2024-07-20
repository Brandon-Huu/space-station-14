namespace Content.Server.Speech.Components
{
    [RegisterComponent]
    public sealed partial class StutteringAccentComponent : Component
    {
        /// <summary>
        /// Percentage chance that a stutter will occur if it matches.
        /// </summary>
        [DataField("matchRandomProb")]
            public float MatchRandomProb = 0.8f;

        /// <summary>
        /// Percentage chance that a stutter occurs f-f-f-f-four times.
        /// </summary>
        [DataField("fourRandomProb")]
            public float FourRandomProb = 0.1f;

        /// <summary>
        /// Percentage chance that a stutter occurs t-t-t-three times.
        /// </summary>
        [DataField("threeRandomProb")]
            public float ThreeRandomProb = 0.2f;

        /// <summary>
        /// Percentage chance that a stutter cut off.
        /// </summary>
        [DataField("cutRandomProb")]
            public float CutRandomProb = 0.05f;
    }
}
