using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class BattleManager : MonoBehaviour
{
    [SerializeField]private ButtonManager bManager;
    // Start is called before the first frame update
    // private 
    [SerializeField]private int[] party = new int[3];
    private Character selectedCharacter;
    private int selectedCharacterId, currentCharacterIndex;
    private bool skillActive;
    private Skill selectedSkill;

    public void SelectSkill(Skill action){
        selectedSkill = action;
    }
    public void SelectCharacter(Character target){

        currentCharacterIndex = getSelectedCharacterIndex();
        selectedCharacter = target;
        selectedCharacterId = target.getId();
        

    }
    public int getSelectedCharacterIndex(){
        for (int i = 0; i < party.GetLength(0); i++)
        {
            if(party[i]==selectedCharacterId){
                return i;
            }
        }
        return 0;
    }
    void Awake()
    {


        skillActive = true;
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if(Input.GetKeyDown(KeyCode.Alpha1)){
            if(skillActive !=true){
                if(currentCharacterIndex != getSelectedCharacterIndex()){
                    Debug.Log("switch");
                }
            }else if(skillActive == true){
                Debug.Log("skill");
            }
        }
    }
}
