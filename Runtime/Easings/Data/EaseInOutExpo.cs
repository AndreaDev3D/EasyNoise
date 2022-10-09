using EasyNoise.Easing.Interfaces;
using UnityEngine;

namespace EasyNoise.Easing
{
    public class EaseInOutExpo : IEasing
    {
        public float Evaluate(float value)
        {
            if (value == 0 || value == 1) return value;

            return value < 0.5f ?
                Mathf.Pow(2, 20 * value - 10) / 2 :
                (2 - Mathf.Pow(2, -20 * value + 10)) / 2;
        }
    }
}
