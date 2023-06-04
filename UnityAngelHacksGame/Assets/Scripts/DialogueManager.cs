using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogueManager : MonoBehaviour
{

    public TextMeshProUGUI nameText;
    public TextMeshProUGUI dialogueText;
    public Animator animator;
    public float textSpeed;


    private Queue<string> sentences;
    private string sentence;

    [SerializeField] private SpriteManager spriteManager;

    [SerializeField] private AudioSource source;
    [SerializeField] private AudioClip clip;

    private Dialogue d;

    public bool occupied;

    void Start()
    {
        sentences = new Queue<string>();
    }

    public void StartDialogue(Dialogue dialogue)
    {

        animator.SetBool("IsOpen", true);

        nameText.text = dialogue.name;

        sentences.Clear();

        spriteManager.UpdateSprites();

        d = dialogue;
        d.inConversation = true;

        occupied = true;

        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }

        // DisplayNextSentence();
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentences.Peek()));

    }

    public void DisplayNextSentence()
    {
        if (sentences.Count == 0)
        {
            EndDialogue();
            return;
        }

        if (sentences.Peek() == dialogueText.text)
        {
            sentences.Dequeue();

            if (sentences.Count == 0)
            {
                EndDialogue();
                return;
            }
            StopAllCoroutines();
            StartCoroutine(TypeSentence(sentences.Peek()));

        }
        else
        {
            StopAllCoroutines();
            dialogueText.text = sentences.Peek();
        }

        // sentence = sentences.Dequeue();
        // StopAllCoroutines();
        // StartCoroutine(TypeSentence(sentence));

    }

    IEnumerator TypeSentence(string sentence)
    {
        dialogueText.text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            dialogueText.text += letter;
            source.PlayOneShot(clip);
            yield return new WaitForSeconds(textSpeed);
        }
    }

    void EndDialogue()
    {
        animator.SetBool("IsOpen", false);
        spriteManager.DisableSprites();

        d.inConversation = false;
        occupied = false;

    }
}
