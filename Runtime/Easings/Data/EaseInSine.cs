using EasyNoise.Easing.Interfaces;
using UnityEngine;

namespace EasyNoise.Easing
{
    public class EaseInSine : IEasing
    {
        public float Evaluate(float value) 
        {
            return (float)Mathf.Cos(value * Mathf.PI / 2f); 
        }
    }
}
