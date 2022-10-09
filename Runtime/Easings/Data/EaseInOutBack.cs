using EasyNoise.Easing.Interfaces;
using UnityEngine;

namespace EasyNoise.Easing
{
    public class EaseInOutBack : IEasing
    {
        public float Evaluate(float value)
        {
            float c1 = 1.70158f;
            float c2 = c1 * 1.525f;

            return value < 0.5
              ? (Mathf.Pow(2 * value, 2) * ((c2 + 1) * 2 * value - c2)) / 2
              : (Mathf.Pow(2 * value - 2, 2) * ((c2 + 1) * (value * 2 - 2) + c2) + 2) / 2;
        }
    }
}
