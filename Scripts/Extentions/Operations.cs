using EasyNoise.Data;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace EasyNoise.Extensions
{
    public static class Operations
    {
        public static Noise Subtract(this Noise noise, Noise minus)
        {
            for (int y = 0; y < noise.Height; y++)
            {
                for (int x = 0; x < noise.Width; x++)
                {
                    noise.Data[x, y] = UnityEngine.Mathf.Clamp(noise.Data[x, y] - minus.Data[x, y], 0, 1);
                }

            }

            return noise;
        }

        public static Noise Add(this Noise noise, Noise minus)
        {
            for (int y = 0; y < noise.Height; y++)
            {
                for (int x = 0; x < noise.Width; x++)
                {
                    noise.Data[x, y] = UnityEngine.Mathf.Clamp(noise.Data[x, y] + minus.Data[x, y], 0, 1);
                }

            }

            return noise;
        }
    }
}
