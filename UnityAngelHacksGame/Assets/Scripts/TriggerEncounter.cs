using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerEncounter : MonoBehaviour
{
    public void OnTriggerEnter2D()
    {
        Debug.Log("triggered");
        SceneManager.LoadScene("Battle");

    }
}
