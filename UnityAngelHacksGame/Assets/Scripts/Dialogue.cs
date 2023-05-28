using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Dialogue : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI textCompenent;
    [SerializeField] private string[] lines;
    [SerializeField] private float textSpeed;

    private int i;
    // Start is called before the first frame update
    void Start()
    {
        textCompenent.text = string.Empty;
        StartDialogue();
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (textCompenent.text == lines[i])
            {
                NextLine();
            }
            else
            {
                StopAllCoroutines();
                textCompenent.text = lines[i];
            }
        }
    }

    private void StartDialogue()
    {
        i = 0;
        StartCoroutine(TypeLine());

    }

    private IEnumerator TypeLine()
    {
        foreach (char c in lines[i].ToCharArray())
        {
            textCompenent.text += c;
            yield return new WaitForSeconds(textSpeed);
        }
    }

    private void NextLine()
    {
        if (i < lines.Length - 1)
        {
            i++;
            textCompenent.text = string.Empty;
            StartCoroutine(TypeLine());
        }
        else
        {
            gameObject.SetActive(false);
        }
    }
}
