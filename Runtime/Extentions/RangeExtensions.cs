namespace EasyNoise.Extensions
{
    public static class RangeExtensions
    {
        public static bool IsWithin(this int value, int minimum, int maximum)
        {
            return value >= minimum && value <= maximum;
        }

        public static bool IsWithin(this float value, float minimum, float maximum)
        {
            return value >= minimum && value <= maximum;
        }
    }
}