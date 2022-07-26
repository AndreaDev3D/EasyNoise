using EasyNoise.Easing.Interfaces;

namespace EasyNoise.Easing
{
    public class EaseRevers : IEasing
    {
        public float Evaluate(float value) => 1 - value;
    }
}
