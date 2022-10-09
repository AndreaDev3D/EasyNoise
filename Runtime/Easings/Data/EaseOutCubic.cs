using EasyNoise.Easing.Interfaces;
using UnityEngine;

namespace EasyNoise.Easing
{
    public class EaseOutCubic : IEasing
    {
        public float Evaluate(float value)
        {
            return 1f - Mathf.Pow(1f - value, 3f);
        }
    }
}
