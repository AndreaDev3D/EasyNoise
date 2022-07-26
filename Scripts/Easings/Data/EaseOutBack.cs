using EasyNoise.Easing.Interfaces;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace EasyNoise.Easing
{
    public class EaseOutBack : IEasing
    {
        public float Evaluate(float value)
        {
            float c1 = 1.70158f;
            float c3 = c1 + 1;

            return 1 + c3 * Mathf.Pow(value - 1, 3) + c1 * Mathf.Pow(value - 1, 2);
        }
    }
}
