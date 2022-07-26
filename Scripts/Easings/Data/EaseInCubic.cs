using EasyNoise.Easing.Interfaces;

namespace EasyNoise.Easing
{
    public class EaseInCubic : IEasing
    {
        public float Evaluate(float value)
        {
            return value * value * value;
        }
    }
}
