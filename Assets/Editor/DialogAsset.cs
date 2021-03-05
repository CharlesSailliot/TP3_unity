using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class DialogAsset
{
    [MenuItem("Assets/Create/DialogueElement")]
    public static void CreateAsset()
    {
        ScriptableObject.CreateInstance<DialogueElement>();

    }
}
