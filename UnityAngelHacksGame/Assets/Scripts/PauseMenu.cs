using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{

    public void backtoMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }

    public void play()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void credits()
    {
        SceneManager.LoadScene("Credits");

    }

}
