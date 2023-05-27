using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    public delegate void selectCharacterEvent(Character target);
    public delegate void selectSkillEvent(Skill action);

    public void StartGame()
    {
        //Start
        Debug.Log("Start");
        
        // SceneManager.LoadScene();
    }
    public void Settings()
    {
        //Start
        Debug.Log("Settings");
        
        // SceneManager.LoadScene();
    }
    public void Quit()
    {
        //Start
        Debug.Log("Quit");
        
        // SceneManager.LoadScene();
    }
    public void selectTarget(){
        
    }
    public void selectSkill(){
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
