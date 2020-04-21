using System;

namespace Body
{
    public class MotionCalculations
    {
        public float GetNetForce(float Mass, float Acceleration)
        {
            float NetForce = Mass * Acceleration;
            return NetForce;
        }
    }

    public class Box : MotionCalculations
    {
        public float Mass;
        public float Acceleration;
        public float Position;
    }
}
