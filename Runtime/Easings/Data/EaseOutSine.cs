using EasyNoise.Easing.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace EasyNoise
{
    public class EaseOutSine : IEasing
    {
        public float Evaluate(float value)
        {
            return (float)Math.Sin(((double)value * Math.PI) / 2d);
        }
    }
}
