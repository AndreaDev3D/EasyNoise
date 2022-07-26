using EasyNoise.Easing.Interfaces;
using UnityEngine;

namespace EasyNoise.Easing
{
    public class EaseInOutQuad : IEasing
    {
        public float Evaluate(float value)
        {
           return value < 0.5 ?
                2 * value * value :
                1 - Mathf.Pow(-2 * value + 2, 2) / 2;
        }
    }
}
