using Boxy2DMath;

namespace Boxy2D
{
    public class BoxBody
    {

        // A body within this 2D Physics engine must have three
        // key properties which are:
        //      - Mass  (
        //      - Velocity (Speed)
        //      - Position (A 2D Vector)

        public float Mass;
        public float Velocity;
        public Vector2D Position;

        public BoxBody(float InitialMass, float InitialVelocity, Vector2D InitialPosition)
        {
            Mass = InitialMass;
            Velocity = InitialVelocity;
            Position = InitialPosition;
        }
    }
}
