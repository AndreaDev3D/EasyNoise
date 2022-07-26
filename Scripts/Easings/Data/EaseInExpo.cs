using EasyNoise.Easing.Interfaces;
using UnityEngine;

namespace EasyNoise.Easing
{
    public class EaseInExpo : IEasing
    {
        public float Evaluate(float value)
        {
            return value == 0 ? 0 : Mathf.Pow(2, 10 * value - 10);
        }
    }
}
