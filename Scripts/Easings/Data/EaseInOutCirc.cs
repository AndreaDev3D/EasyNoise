using EasyNoise.Easing.Interfaces;
using UnityEngine;

namespace EasyNoise.Easing
{
    public class EaseInOutCirc : IEasing
    {
        public float Evaluate(float value)
        {
            return value < 0.5 ? (1 - Mathf.Sqrt(1 - Mathf.Pow(2 * value, 2))) / 2 : (Mathf.Sqrt(1 - Mathf.Pow(-2 * value + 2, 2)) + 1) / 2;
        }
    }
}
