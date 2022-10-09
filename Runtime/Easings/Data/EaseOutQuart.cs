using EasyNoise.Easing.Interfaces;
using UnityEngine;

namespace EasyNoise.Easing
{
    public class EaseOutQuart : IEasing
    {
        public float Evaluate(float value)
        {
            return 1 - Mathf.Pow(1 - value, 4);
        }
    }
}
