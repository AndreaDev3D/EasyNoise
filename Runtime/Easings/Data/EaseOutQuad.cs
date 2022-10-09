using EasyNoise.Easing.Interfaces;

namespace EasyNoise.Easing
{
    public class EaseOutQuad : IEasing
    {
        public float Evaluate(float value)
        {
            return 1 - (1 - value) * (1 - value);
        }
    }
}
