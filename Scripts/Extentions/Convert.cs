using EasyNoise.Data;
using EasyNoise.Extensions;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace EasyNoise.Extensions
{
    public static class Convert
    {
        public static Noise ToStep(this Noise noise, int step = 4, int minStep = 0, int maxStep = 0)
        {
            for (int x = 0; x < noise.Width; x++)
            {
                for (int y = 0; y < noise.Height; y++)
                {
                    var value = (float)Math.Round(noise.Data[x, y], 2);
                    var stepFloat = (float)Math.Round(1f / (float)step, 2);
                    for (int i = 0; i < step; i++)
                    {
                        if (value < 0f)
                        {
                            continue;
                        }

                        var min = stepFloat * i;
                        var max = min + stepFloat;


                        if (value.IsWithin(min, max))
                        {
                            if (minStep > 0 || maxStep > 0)
                            {
                                if (min.IsWithin(stepFloat * minStep, stepFloat * maxStep))
                                {
                                    noise.Data[x, y] = stepFloat * maxStep;
                                    continue;
                                }
                            }
                            else
                            {
                                noise.Data[x, y] = min;
                                continue;
                            }
                        }
                    }
                }
            }

            return noise;
        }

        public static Color[] ToColorArray(this Noise noise)
        {
            var convertedList = new List<Color>();

            for (int x = 0; x < noise.Width; x++) { 
                for (int y = 0; y < noise.Height; y++)            
                {
                    var value = Mathf.InverseLerp(0f, 1f, noise.Data[x, y]);
                    convertedList.Add(new Color(value, value, value, 1f));
                }
            }
            return convertedList.ToArray();
        }

    }
}
