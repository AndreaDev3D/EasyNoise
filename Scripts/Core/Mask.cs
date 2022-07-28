using EasyNoise.Data;
using EasyNoise.Easing.Core;
using EasyNoise.Extensions;
using UnityEngine;

namespace EasyNoise.Core
{
    public static class Mask
    {
        public static Noise MaskSquare(this Noise noise, int size, int originX, int originY, Easings.EasingType easingType = Easings.EasingType.Easelinear)
        {
            var easing = Easings.GetEasing(easingType);
            for (int x = 0; x < noise.Width; x++)
            {
                for (int y = 0; y < noise.Height; y++)
                {
                    bool result = x.IsWithin(originX, originX + size) && y.IsWithin(originY, originY + size);
                    noise.Data[x, y] = easing.Evaluate(result ? 1f : 0f);
                }
            }

            return noise;
        }

        public static Noise MaskRound(this Noise noise, int size, int originX, int originY, Easings.EasingType easingType = Easings.EasingType.Easelinear)
        {
            var easing = Easings.GetEasing(easingType);
            for (int x = 0; x < noise.Width; x++)
            {
                for (int y = 0; y < noise.Height; y++)
                {
                    var result = Vector2Int.Distance(new Vector2Int(originX, originY), new Vector2Int(x, y));
                    noise.Data[x, y] = easing.Evaluate(result <= size ? 1f : 0f);
                }
            }

            return noise;
        }
    }
}
