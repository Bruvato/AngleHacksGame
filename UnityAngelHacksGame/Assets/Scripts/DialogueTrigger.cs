using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    [SerializeField] public Dialogue dialogue;


    public void OnMouseDown()
    {
        if (!FindObjectOfType<DialogueManager>().occupied)
            TriggerDialogue();
    }
    public void OnMouseEnter()
    {
        if (!FindObjectOfType<DialogueManager>().occupied)
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
