using EasyNoise.Easing.Interfaces;

namespace EasyNoise.Easing
{
    public class EaseInQuint : IEasing
    {
        public float Evaluate(float value)
        {
            return value * value * value * value * value;
        }
    }
}
