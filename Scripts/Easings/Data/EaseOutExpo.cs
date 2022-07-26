using EasyNoise.Easing.Interfaces;
using UnityEngine;

namespace EasyNoise.Easing
{
    public class EaseOutExpo : IEasing
    {
        public float Evaluate(float value)
        {
            return value == 1 ? 1 : 1 - Mathf.Pow(2, -10 * value);
        }
    }
}
