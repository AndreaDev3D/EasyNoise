using EasyNoise.Data;
using UnityEngine;

namespace EasyNoise.Core
{
    public static class Generator
    {

        public static Noise PerlinNoise(this Noise noise, float scale, float xOrg = 0, float yOrg = 0)
        {
            for (int x = 0; x < noise.Width; x++) 
            { 
                for (int y = 0; y < noise.Height; y++)            
                {
                    float xCoord = xOrg + ((float)x / (float)noise.Width * scale);
                    float yCoord = yOrg + ((float)y / (float)noise.Height * scale);
                    noise.Data[x, y] = Mathf.PerlinNoise(xCoord, yCoord);
                }
            }
            return noise;
        }

        public static Noise SimpleNoise(this Noise noise, float scale, int octaves = 2, float persistance = 0.5f, float lacunarity = 2.0f, float xOrg = 0, float yOrg = 0)
        {
            if (scale <= 0.0f)
                scale = 0.0001f;

            float maxNoiseHeight = float.MinValue;
            float minNoiseHeight = float.MaxValue;

            for (int x = 0; x < noise.Width; x++)
            {
                for (int y = 0; y < noise.Height; y++)
                {
                    var amplitude = 1f;
                    var frequency = 1f;
                    var noiseHeight = 0f;
                    for (int o = 0; o < octaves; o++)
                    {
                        float xVal = xOrg + (x / scale * frequency);
                        float yVal = yOrg + (y / scale * frequency);

                        float value = Mathf.PerlinNoise(xVal, yVal) * 2 - 1;
                        noiseHeight += value * amplitude;
                        amplitude *= persistance;
                        frequency *= lacunarity;

                    }

                    if (noiseHeight > maxNoiseHeight)
                    {
                        maxNoiseHeight = noiseHeight;
                    }
                    else if (noiseHeight < minNoiseHeight)
                    {
                        minNoiseHeight = noiseHeight;
                    }

                    //noise.Data[x, y] = noiseHeight;

                    noise.Data[x, y] = Mathf.InverseLerp(minNoiseHeight, maxNoiseHeight, noiseHeight);
                }
            }
            return noise;
        }
    }
}
