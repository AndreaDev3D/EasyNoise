using EasyNoise.Data;
using System.IO;
using UnityEditor;
using UnityEngine;

namespace EasyNoise.Extensions
{
    public static class NoiseExtentions
    {
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