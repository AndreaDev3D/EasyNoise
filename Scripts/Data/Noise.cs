using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace EasyNoise.Data
{
    public struct Noise
    {
        public int Width;
        public int Height;
        public float[,] Data;

        public Noise(int width, int height)
        {
            Width = width;
            Height = height;
            Data = new float[Width, Height];
        }

        public float Evaluate(int x, int y) => Data[x, y];

        public bool IsValid() => Data != null && Data.GetLength(0) == Width && Data.GetLength(1) == Height;
        public bool IsValidSize(int width, int height) => Data != null && Data.GetLength(0) == width && Data.GetLength(1) == height;

        public void Dispose()
        {
            // Suppress finalization.
            GC.SuppressFinalize(this);
        }
    }
}