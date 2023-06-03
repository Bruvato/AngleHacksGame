using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteManager : MonoBehaviour
{
    [SerializeField] private DialogueManager dialogueManager;
    [SerializeField] private GameObject[] sprites;

    public void UpdateSprites()
    {
        sprites[0].SetActive(true);
        foreach (GameObject sprite in sprites)
        {
            if (dialogueManager.nameText.text == sprite.name)
            {
                sprite.SetActive(true);
            }
        }
    }

    public void DisableSprites()
    {
        foreach (GameObject sprite in sprites)
        {
            sprite.SetActive(false);
        }

    }
}
