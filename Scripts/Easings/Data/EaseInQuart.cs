using EasyNoise.Easing.Interfaces;

namespace EasyNoise.Easing
{
    public class EaseInQuart : IEasing
    {
        public float Evaluate(float value)
        {
            return value * value * value * value;
        }
    }
}
