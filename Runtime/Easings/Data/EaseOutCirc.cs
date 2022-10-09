using EasyNoise.Easing.Interfaces;
using UnityEngine;

namespace EasyNoise.Easing
{
    public class EaseOutCirc : IEasing
    {
        public float Evaluate(float value)
        {
            return Mathf.Sqrt(1 - Mathf.Pow(value - 1, 2)); ;
        }
    }
}
