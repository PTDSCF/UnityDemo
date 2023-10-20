using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="New Level")]
public class LevelData : ScriptableObject
{
    public string name;
    public string displayName;
    public int level;
    public float playTime;
    public List<Sprite> tile;
}
