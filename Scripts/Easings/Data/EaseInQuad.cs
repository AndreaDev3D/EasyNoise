using EasyNoise.Easing.Interfaces;

namespace EasyNoise.Easing
{
    public class EaseInQuad : IEasing
    {
        public float Evaluate(float value)
        {
            return value * value;
        }
    }
}
