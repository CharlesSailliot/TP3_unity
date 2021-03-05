using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class dialogueBox : MonoBehaviour
{
    private String[] Dialogue = new string[3];
    private int idx;
    public TMP_Text myText;
    public Button myButton;

    private void Awake()
    {
        idx = 0;
        Dialogue[0]="orem ipsum dolor sit amet, consectetur adipiscing elit.";
        Dialogue[1]="Mauris vehicula mauris non fringilla convallis.";
        Dialogue[2]="Phasellus eu lacus nec nibh mattis semper.";
       
    }

    // Start is called before the first frame update
    void Start()
    {
        nextDialogue();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void nextDialogue()
    {
        
        myText.text = Dialogue[idx];
        idx++;
        if (idx > Dialogue.Length-1)
        {
            myButton.interactable = false;
        }
        

    }
}
