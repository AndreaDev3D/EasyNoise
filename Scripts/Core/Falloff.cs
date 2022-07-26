using EasyNoise.Data;
using EasyNoise.Easing.Core;
using UnityEngine;

namespace EasyNoise.Core
{
    public static class Falloff
    {
        public static Noise FalloffSimple(this Noise noise, float powerA = 3f, float powerB = 2.2f, Easings.EasingType easingType = Easings.EasingType.Easelinear)
        {
            var easing = Easings.GetEasing(easingType);
            for (int x = 0; x < noise.Width; x++)
            {
                for (int y = 0; y < noise.Height; y++)
                {
                    var _width = x / (float)noise.Width * 2 - 1;
                    var _height = y / (float)noise.Height * 2 - 1;

                    var value = Mathf.Max(Mathf.Abs(_width), Mathf.Abs(_height));
                    var result = Mathf.Pow(value, powerA) / (Mathf.Pow(value, powerA) + Mathf.Pow(powerB - powerB * value, powerA));
                    noise.Data[x, y] = easing.Evaluate(result);
                }
            }

            return noise;
        }
        public static Noise FalloffRadial(this Noise noise, float radius, Easings.EasingType easingType = Easings.EasingType.Easelinear)
        {
            var easing = Easings.GetEasing(easingType);
            for (int x = 0; x < noise.Width; x++)
            {
                for (int y = 0; y < noise.Height; y++)
                {
                    float cx = noise.Width / 2f;
                    float cy = noise.Height / 2f;
                    var centerPosition = new Vector2(cx, cy);
                    var currentPosition = new Vector2(x, y);
                    var distance = Vector2.Distance(currentPosition, centerPosition);
                    float t = Mathf.InverseLerp(0, radius/2f, distance);

                    noise.Data[x, y] = easing.Evaluate(t);
                }
            }

            return noise;
        }

        // https://stackoverflow.com/questions/69725525/unity-how-to-create-circular-gradient
        /// <summary>
        /// 
        /// </summary>
        /// <param name="value">The calculated value to process</param>
        /// <param name="radius">The distance from center to calculate falloff distance</param>
        /// <param name="cx">The x-coordinate of the center position</param>
        /// <param name="cy">The y-coordinate of the center position</param>
        /// <returns></returns>
        public static Noise FalloffSolidRadial(this Noise noise, float radius, Easings.EasingType easingType = Easings.EasingType.Easelinear)
        {
            var easing = Easings.GetEasing(easingType);
            for (int x = 0; x < noise.Width; x++)
            {
                for (int y = 0; y < noise.Height; y++)
                {
                    float cx = noise.Width / 2f;
                    float cy = noise.Height / 2f;
                    float dx = cx - x;
                    float dy = cy - y;
                    float distSqr = dx * dx + dy * dy;
                    float radSqr = radius * radius;

                    noise.Data[x, y] = distSqr >= radSqr ? easing.Evaluate(1f) : 0f;
                }
            }

            return noise;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value">The calculated value to process</param>
        /// <param name="innerRadius">The inner distance from center to calculate falloff distance</param>
        /// <param name="outerRadius">The outer distance from center to calculate falloff distance</param>
        /// <param name="cx">The x-coordinate of the center position</param>
        /// <param name="cy">The y-coordinate of the center position</param>
        /// <returns></returns>
        public static Noise FallOffFeatheredRadial(this Noise noise, float innerRadius, float outerRadius, Easings.EasingType easingType = Easings.EasingType.Easelinear)
        {
            var easing = Easings.GetEasing(easingType);
            var value = 0f;
            for (int x = 0; x < noise.Width; x++)
            {
                for (int y = 0; y < noise.Height; y++)
                {
                    float cx = noise.Width / 2f;
                    float cy = noise.Height / 2f;
                    float dx = cx - x;
                    float dy = cy - y;
                    float distSqr = dx * dx + dy * dy;
                    float iRadSqr = innerRadius * innerRadius;
                    float oRadSqr = outerRadius * outerRadius;

                    value = noise.Data[x, y];
                    if (distSqr >= oRadSqr)
                        value = 0f;

                    if (distSqr <= iRadSqr)
                    {
                        noise.Data[x, y] = value;
                    }
                    else
                    {
                        float dist = Mathf.Sqrt(distSqr);
                        float t = Mathf.InverseLerp(innerRadius, outerRadius, dist);
                        // Use t with whatever easing you want here, or leave it as is for linear easing
                        noise.Data[x, y] = value * easing.Evaluate(t);
                    }
                }
            }
            return noise;
        }
    }
}
