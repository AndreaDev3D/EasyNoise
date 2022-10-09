using EasyNoise.Easing.Interfaces;
using UnityEngine;

namespace EasyNoise.Easing
{
    public class EaseInOutQuart : IEasing
    {
        public float Evaluate(float value)
        {
            return value < 0.5 ? 
                8 * value * value * value * value : 
                1 - Mathf.Pow(-2 * value + 2, 4) / 2;
        }
    }
}
