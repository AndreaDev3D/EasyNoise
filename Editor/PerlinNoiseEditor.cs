using EasyNoise.Demo;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(PerlinNoise))]
public class PerlinNoiseEditor : Editor
{
    public override void OnInspectorGUI()
    {
        PerlinNoise _target = (PerlinNoise)target;
        DrawDefaultInspector();
        if (GUILayout.Button("Save as 2DTexture"))
        {
            SaveTexture(_target.m_Texture);
        }
    }

    private void SaveTexture(Texture2D texture)
    {
        byte[] bytes = texture.EncodeToPNG();
        var dirPath = Path.Combine(Application.dataPath, "Output");
        var fileName = "R_" + Random.Range(0, 100000) + ".png";
        var fullDir = Path.Combine(dirPath, fileName);
        if (!Directory.Exists(dirPath))
        {
            Directory.CreateDirectory(dirPath);
        }
        File.WriteAllBytes(fullDir, bytes);
        Debug.Log(bytes.Length / 1024 + "Kb was saved as: " + fullDir);
#if UNITY_EDITOR
        UnityEditor.AssetDatabase.Refresh();
#endif
    }
}
