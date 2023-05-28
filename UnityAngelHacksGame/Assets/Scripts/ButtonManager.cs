using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{

    private Skill selectedSkill;
    private Character selectedCharacter;

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
        
        // character?.Invoke();
    }
    public void selectSkill(){
        // skill?.Invoke();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
