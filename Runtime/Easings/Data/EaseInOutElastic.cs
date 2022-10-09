using EasyNoise.Easing.Interfaces;
using UnityEngine;

namespace EasyNoise.Easing
{
    public class EaseInOutElastic : IEasing
    {
        public float Evaluate(float value)
        {
            float c5 = (2 * Mathf.PI) / 4.5f;


            if (value == 0 || value == 1) return value;

            return value < 0.5f ? 
                -(Mathf.Pow(2, 20 * value - 10) * Mathf.Sin((20 * value - 11.125f) * c5)) / 2 :
                (Mathf.Pow(2, -20 * value + 10) * Mathf.Sin((20 * value - 11.125f) * c5)) / 2 + 1;
        }
    }
}
