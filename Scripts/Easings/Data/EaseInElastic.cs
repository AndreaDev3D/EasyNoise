using EasyNoise.Easing.Interfaces;
using UnityEngine;

namespace EasyNoise.Easing
{
    public class EaseInElastic : IEasing
    {
        public float Evaluate(float value)
        {
            if (value == 0f || value == 1f) return value;

            var c4 = (2 * Mathf.PI) / 3;
            return -Mathf.Pow(2, 10 * value - 10) * Mathf.Sin((value * 10 - 10.75f) * c4);
        }
    }
}
