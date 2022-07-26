using EasyNoise.Easing.Interfaces;

namespace EasyNoise.Easing.Core
{
    // https://easings.net/
    // https://www.desmos.com/calculator?lang=en
    public static class Easings
    {
        public enum EasingType
        {
            Easelinear, EaseRevers,
            EaseInSine, EaseOutSine, EaseInOutSine,
            EaseInCubic, EaseOutCubic, EaseInOutCubic,
            EaseInQuint, EaseOutQuint, EaseInOutQuint,
            EaseInCirc, EaseOutCirc, EaseInOutCirc,
            EaseInElastic, EaseOutElastic, EaseInOutElastic,
            EaseInQuad, EaseOutQuad, EaseInOutQuad,
            EaseInQuart, EaseOutQuart, EaseInOutQuart,
            EaseInExpo, EaseOutExpo, EaseInOutExpo,
            EaseInBack, EaseOutBack, EaseInOutBack,
            EaseInBounce, EaseOutBounce, EaseInOutBounce
        }

        public static IEasing GetEasing(EasingType easingType = EasingType.Easelinear)
        {
            switch (easingType)
            {
                default : return new EaseLinear();
                case EasingType.EaseRevers: return new EaseRevers();
                case EasingType.EaseInSine: return new EaseInSine();
                case EasingType.EaseOutSine: return new EaseOutSine();
                case EasingType.EaseInOutSine: return new EaseInOutSine();
                case EasingType.EaseInCubic: return new EaseInCubic();
                case EasingType.EaseOutCubic: return new EaseOutCubic();
                case EasingType.EaseInOutCubic: return new EaseInOutCubic();
                case EasingType.EaseInQuint: return new EaseInQuint();
                case EasingType.EaseOutQuint:  return new EaseOutQuint();
                case EasingType.EaseInOutQuint: return new EaseInOutQuint();
                case EasingType.EaseInCirc: return new EaseInCirc();
                case EasingType.EaseOutCirc: return new EaseOutCirc();
                case EasingType.EaseInOutCirc: return new EaseInOutCirc();
                case EasingType.EaseInElastic: return new EaseInElastic();
                case EasingType.EaseOutElastic: return new EaseOutElastic();
                case EasingType.EaseInOutElastic: return new EaseInOutElastic();
                case EasingType.EaseInQuad: return new EaseInQuad();
                case EasingType.EaseOutQuad: return new EaseOutQuad();
                case EasingType.EaseInOutQuad: return new EaseInOutQuad();
                case EasingType.EaseInQuart: return new EaseInQuart();
                case EasingType.EaseOutQuart: return new EaseOutQuart();
                case EasingType.EaseInOutQuart: return new EaseInOutQuart();
                case EasingType.EaseInExpo: return new EaseInExpo();
                case EasingType.EaseOutExpo: return new EaseOutExpo();
                case EasingType.EaseInOutExpo: return new EaseInOutExpo();
                case EasingType.EaseInBack: return new EaseInBack();
                case EasingType.EaseOutBack: return new EaseOutBack();
                case EasingType.EaseInOutBack: return new EaseInOutBack();
                case EasingType.EaseInBounce: return new EaseInBounce();
                case EasingType.EaseOutBounce: return new EaseOutBounce();
                case EasingType.EaseInOutBounce: return new EaseInOutBounce();
            }
        } 
    }     
}