using EasyNoise.Easing.Interfaces;

namespace EasyNoise.Easing
{
    public class EaseLinear : IEasing
    {
        public float Evaluate(float value) => value;
    }
}
