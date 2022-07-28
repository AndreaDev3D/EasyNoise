using EasyNoise.Core;
using EasyNoise.Data;
using EasyNoise.Easing.Core;
using EasyNoise.Extensions;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UI;

namespace EasyNoise.Demo
{
    public class PerlinNoise : MonoBehaviour
    {
        public int2 NoiseSize;
        public bool AutoUpdate;
        [Header("Simple Noise")]
        public bool HasNoise;
        public float NoiseScale;
        public float OriginX, OriginY;
        [Header("Step Noise")]
        public bool HasNoiseStep;
        public int NoiseStep = 6;

        [Header("FallOff Noise")]
        public bool HasFalloff;
        public float Radius = 256f;
        public Easings.EasingType EasingType;
        public Gradient Gradient;

        public Noise m_NoiseMap;
        public Noise m_FalloffMap;
        public List<Noise> m_FalloffMaps;

        [Header("Texture Noise")]
        public Texture2D m_Texture;

        [Header("Output")]
        public RawImage RawImage;

        private void OnValidate()
        {
            if (!AutoUpdate) return;
            ValidateNoise();
            Generate();
        }

        public void ValidateNoise()
        {
            if (!m_NoiseMap.IsValid() || !m_NoiseMap.IsValidSize(NoiseSize.x, NoiseSize.y))
                m_NoiseMap = new Noise(NoiseSize.x, NoiseSize.y);
            if (!m_FalloffMap.IsValid() || !m_FalloffMap.IsValidSize(NoiseSize.x, NoiseSize.y))
                m_FalloffMap = new Noise(NoiseSize.x, NoiseSize.y);
        }

        public void Generate()
        {
            if (HasNoise) 
            {
                m_NoiseMap.SimpleNoise(NoiseScale,xOrg:OriginX, yOrg:OriginY);

                if (HasNoiseStep)
                {
                    m_NoiseMap.ToStep(NoiseStep);
                }
            }
            
            if (HasFalloff)
            {
                m_FalloffMap.FalloffRadial(Radius, EasingType);

                if (HasNoiseStep) 
                { 
                    m_FalloffMap.ToStep(NoiseStep);
                }

                if (HasNoise)
                {
                    m_NoiseMap.Subtract(m_FalloffMap);
                }
            }

            m_Texture = (HasNoise ? m_NoiseMap : m_FalloffMap).ToTexture("Perlin", Gradient, filterMode:FilterMode.Bilinear);
            RawImage.texture = m_Texture;
        }
    }
}
