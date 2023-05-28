using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartMenu : MonoBehaviour
{

    public void StartGame()
    {
        Debug.Log("Start");
        SceneManager.LoadScene("SampleScene");
    }
    public void Settings()
    {
        Debug.Log("Settings");
        SceneManager.LoadScene("Settings");
    }
    public void Quit()
    {
        Debug.Log("Quit");
        Application.Quit();
    }

    void Update()
    {

    }



}
