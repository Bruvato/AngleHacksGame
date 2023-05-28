using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class BattleManager : MonoBehaviour
{
    private Dictionary<int, Character> orderList;//character, id
    [SerializeField]private ButtonManager bManager;
    // Start is called before the first frame update
    // private 

    [SerializeField]private Character[] party = new Character[3];
    
    [SerializeField]private Character selectedCharacter;
    [SerializeField]private int selectedCharacterId, currentCharacterIndex;
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

            if(party[i].getId()==selectedCharacterId){
                Debug.Log(i);

                return i;
            }

        }
        return 0;
    }
    public int getTargetedCharacterIndex(int id){
        for (int i = 0; i < party.GetLength(0); i++)
        {
            if(party[i].getId()==id){
                return i;
            }

        }
        return 0;
    }
    void Awake()
    {
        orderList = new Dictionary<int, Character>();
        int count =0;
        foreach (Character c in party)
        {
            Debug.Log(c);
            Debug.Log(count);

            orderList.Add(count, c);
            count++;
        }

        currentCharacterIndex = 0;

        skillActive = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if(Input.GetKeyDown(KeyCode.Alpha1)){
            if(skillActive !=true){
                if(currentCharacterIndex != getTargetedCharacterIndex(orderList[0].getId())){
                    Debug.Log("switch");
                    SelectCharacter(orderList[0]);
                }
            }else if(skillActive == true){
                Debug.Log("skill");
            }
        }
        if(Input.GetKeyDown(KeyCode.Alpha2)){
            if(skillActive !=true){
                if(currentCharacterIndex != getTargetedCharacterIndex(orderList[1].getId())){
                    Debug.Log("switch");
                    SelectCharacter(orderList[1]);
                }
            }else if(skillActive == true){
                Debug.Log("skill");
            }
        }
    }
}
