namespace Content.Shared.Rotatable
{
    [RegisterComponent]
    public sealed partial class RotatableComponent : Component
    {
        /// <summary>
        ///     If true, this entity can be rotated even while anchored.
        /// </summary>
            [DataField("rotateWhileAnchored")]
        public bool RotateWhileAnchored { get; private set; }

        /// <summary>
        ///     If true, will rotate entity in players direction when pulled
        /// </summary>
            [DataField("rotateWhilePulling")]
        public bool RotateWhilePulling { get; private set; } = true;

        /// <summary>
        ///     The angular value to change when using the rotate verbs.
        /// </summary>
            [DataField("increment")]
        public Angle Increment { get; private set; } = Angle.FromDegrees(90);
    }
}
