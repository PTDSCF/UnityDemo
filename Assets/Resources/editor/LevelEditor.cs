using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.UIElements;
using System.Linq;

public class LevelEditor : EditorWindow
{


    // Start is called before the first frame update
   
    [MenuItem("Window/Level Designer")]
   static void OpenWindow()
    {
        LevelEditor window = (LevelEditor)GetWindow(typeof(LevelEditor));
        window.minSize = new Vector2(800, 500);
        window.Show();
    }
  

    private void OnGUI()
    {
        LevelData levelData = new LevelData();
        EditorGUILayout.BeginHorizontal();
        EditorGUILayout.LabelField("Name");
        levelData.name = EditorGUILayout.TextField(levelData.name);
        EditorGUILayout.EndHorizontal();

        EditorGUILayout.BeginHorizontal();
        EditorGUILayout.LabelField("Display Name");
        levelData.displayName = EditorGUILayout.TextField(levelData.displayName);
        EditorGUILayout.EndHorizontal();

        EditorGUILayout.BeginHorizontal();
        EditorGUILayout.LabelField("Level");
        levelData.level = EditorGUILayout.IntField(levelData.level);
        EditorGUILayout.EndHorizontal();

        EditorGUILayout.BeginHorizontal();
        EditorGUILayout.LabelField("Play time");
        levelData.playTime = EditorGUILayout.FloatField(levelData.playTime);
        EditorGUILayout.EndHorizontal();

        var allObjectGuids = AssetDatabase.FindAssets("t:Sprite");
        var allObjects = new List<Sprite>();
        foreach (var guid in allObjectGuids)
        {
            allObjects.Add(AssetDatabase.LoadAssetAtPath<Sprite>(AssetDatabase.GUIDToAssetPath(guid)));
        }

        Vector2 scrollpos =  Vector2.zero;
        float y = 0.0f;
        

        scrollpos = EditorGUILayout.BeginScrollView(scrollpos,GUILayout.Height(100));
        EditorGUILayout.BeginHorizontal();

       

        EditorGUILayout.EndHorizontal();
        EditorGUILayout.EndScrollView();

        //rootVisualElement.Add(table);



    }



}
