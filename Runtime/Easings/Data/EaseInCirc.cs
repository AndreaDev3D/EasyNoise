using EasyNoise.Easing.Interfaces;
using UnityEngine;

namespace EasyNoise.Easing
{
    public class EaseInCirc : IEasing
    {
        public float Evaluate(float value)
        {
            return 1 - Mathf.Sqrt(1 - Mathf.Pow(value, 2));
        }
    }
}
