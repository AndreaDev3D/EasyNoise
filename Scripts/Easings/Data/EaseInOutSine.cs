using EasyNoise.Easing.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace EasyNoise
{
    public class EaseInOutSine : IEasing
    {
        public float Evaluate(float value)
        {
            return -(Mathf.Cos(Mathf.PI * value) - 1) / 2;
        }
    }
}
