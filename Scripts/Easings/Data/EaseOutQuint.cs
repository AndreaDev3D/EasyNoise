using EasyNoise.Easing.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace EasyNoise.Easing
{
    public class EaseOutQuint : IEasing
    {
        public float Evaluate(float value)
        {
            return 1 - Mathf.Pow(1 - value, 5);
        }
    }
}
