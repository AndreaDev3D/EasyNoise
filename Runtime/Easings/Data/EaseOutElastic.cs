using EasyNoise.Easing.Interfaces;
using UnityEngine;

namespace EasyNoise.Easing
{
    public class EaseOutElastic : IEasing
    {
        public float Evaluate(float value)
        {
            if (value == 0 || value == 1) return value;
            
            var c4 = (2 * Mathf.PI) / 3;
            return Mathf.Pow(2, -10 * value) * Mathf.Sin((value * 10 - 0.75f) * c4) + 1;
        }
    }
}
