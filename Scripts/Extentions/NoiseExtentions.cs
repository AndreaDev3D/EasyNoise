using EasyNoise.Data;
using System.IO;
using UnityEditor;
using UnityEngine;

namespace EasyNoise.Extensions
{
    public static class NoiseExtentions
    {


        public static Texture2D ToTexture(this Noise noise, string name = "", FilterMode filterMode = FilterMode.Point, TextureWrapMode textureWrapMode = TextureWrapMode.Clamp)
        {
            var _textureStep = new Texture2D(noise.Width, noise.Height);
            _textureStep.SetPixels(noise.ToColorArray());
            _textureStep.Apply();
            _textureStep.wrapMode = textureWrapMode;
            _textureStep.filterMode = filterMode;
            _textureStep.name = name;
            _textureStep.Apply();

            return _textureStep;
        }

        public static void SaveTexture(Texture2D texture2D, string name)
        {
            var path = Application.dataPath + "/../Assets/Resources/Noise/" + (!string.IsNullOrEmpty(name) ? name : System.DateTime.Now.ToString("yyyymmdd")) + ".png";
            File.WriteAllBytes(path, texture2D.EncodeToPNG());
#if UNITY_EDITOR
            AssetDatabase.Refresh();
#endif
        }
    }
}