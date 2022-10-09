using EasyNoise.Easing.Interfaces;

namespace EasyNoise.Easing
{
    public class EaseOutBounce : IEasing
    {
        public float Evaluate(float value)
        {
            return 1 - NegativBounce(1 - value);
        }

        internal float NegativBounce(float value) 
        {
            float n1 = 7.5625f;
            float d1 = 2.75f;

            if (value < 1 / d1)
            {
                return n1 * value * value;
            }
            else if (value < 2 / d1)
            {
                return n1 * (value -= 1.5f / d1) * value + 0.75f;
            }
            else if (value < 2.5 / d1)
            {
                return n1 * (value -= 2.25f / d1) * value + 0.9375f;
            }
            else
            {
                return n1 * (value -= 2.625f / d1) * value + 0.984375f;
            }
        }
    }
}
