using EasyNoise.Easing.Interfaces;
using UnityEngine;

namespace EasyNoise.Easing
{
    public class EaseInOutCubic : IEasing
    {
        public float Evaluate(float value)
        {
                return value < 0.5f ? 4f * value * value * value : 1f - Mathf.Pow(-2 * value + 2, 3) / 2f;            
        }
    }
}
