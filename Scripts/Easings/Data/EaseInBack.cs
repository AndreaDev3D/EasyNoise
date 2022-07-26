using EasyNoise.Easing.Interfaces;

namespace EasyNoise.Easing
{
    public class EaseInBack : IEasing
    {
        public float Evaluate(float value)
        {
            float c1 = 1.70158f;
            float c3 = c1 + 1f;

            return c3 * value * value * value - c1 * value * value;
        }
    }
}
