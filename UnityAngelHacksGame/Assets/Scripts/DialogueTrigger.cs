using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    [SerializeField] public Dialogue dialogue;


    public void OnMouseDown()
    {
        TriggerDialogue();
    }
    public void OnMouseEnter()
    {
        GetComponent<SpriteRenderer>().color = Color.grey;
    }
    public void OnMouseExit()
    {
        GetComponent<SpriteRenderer>().color = Color.white;

    }

    public void TriggerDialogue()
    {
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
    }
}
