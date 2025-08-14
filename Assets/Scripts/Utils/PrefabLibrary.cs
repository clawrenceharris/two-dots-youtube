using System;
using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEngine;

[CreateAssetMenu(fileName = "PrefabLibrary", menuName = "Scriptable Objects/Prefab Library")]
public class PrefabLibrary : ScriptableSingleton<PrefabLibrary>
{
    [SerializeField] private List<Dot> Dots;

    public Dot GetDotPrefab(DotType type)
    {
        return Dots.FirstOrDefault((dot) => dot.Type == type);
    }

    
}
