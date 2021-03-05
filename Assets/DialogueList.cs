using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueList : ScriptableObject
{
    public List<DialogueElement> DialogueElements;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
[System.Serializable]
public class DialogueElement:ScriptableObject
{
    private String Dialogue;


}