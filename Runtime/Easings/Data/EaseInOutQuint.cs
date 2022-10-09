using EasyNoise.Easing.Interfaces;
using UnityEngine;

namespace EasyNoise.Easing
{
    public class EaseInOutQuint : IEasing
    {
        public float Evaluate(float value)
        {
            return value < 0.5f ? 16f * value * value * value * value * value : 1f - Mathf.Pow(-2f * value + 2f, 5f) / 2f;
        }
    }
}
