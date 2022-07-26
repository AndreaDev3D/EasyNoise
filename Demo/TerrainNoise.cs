using EasyNoise.Core;
using EasyNoise.Data;
using EasyNoise.Easing.Core;
using EasyNoise.Extensions;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace EasyNoise.Demo
{
    public class TerrainNoise : MonoBehaviour
    {
        public Terrain m_Terrain;
        [Header("Perlin Noise")]
        public Noise m_NoiseMap;
        public int NoiseSize = 512;
        public float NoiseScale = 4.5f;
        [Header("FallOff Noise")]
        public Noise m_FalloffMap;
        public float Radius = 256f;
        public Easings.EasingType EasingType;

        [Header("Output")]
        private Texture2D m_Texture;
        public RawImage RawImage;

        private void OnValidate()
        {
            NoiseSize = m_Terrain.terrainData.heightmapResolution;
            m_NoiseMap = new Noise(NoiseSize, NoiseSize);
            m_FalloffMap = new Noise(NoiseSize, NoiseSize);

            m_NoiseMap.PerlinNoise(NoiseScale, 0, 0); 
            m_FalloffMap.FalloffRadial(Radius, EasingType); 
            m_NoiseMap.Subtract(m_FalloffMap);

            m_Terrain.terrainData.SetHeights(0, 0, m_NoiseMap.Data);

            m_Texture = m_NoiseMap.ToTexture("Perlin", filterMode: FilterMode.Bilinear);
            RawImage.texture = m_Texture;
        }
    }
}
