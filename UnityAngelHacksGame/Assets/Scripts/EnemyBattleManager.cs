using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class EnemyBattleManager : MonoBehaviour
{
    private Dictionary<int, Character> orderList;//character, id
    // [SerializeField]private ButtonManager bManager;
    // Start is called before the first frame update
    // private 

    [SerializeField]private Character[] party = new Character[3];
    [SerializeField]private Character[] partyOrder = new Character[3];
    
    [SerializeField]private Character selectedCharacter;
    [SerializeField]private int selectedCharacterId, currentCharacterIndex;
    private bool skillActive;
    private Skill selectedSkill;
    private bool a0, a1, a2;
    public string atk;

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
        partyOrder = party;

        for (int i = 0; i < party.GetLength(0); i++)
        {
            for (int j = i+1; j < party.GetLength(0); j++)
            {
                if(party[i].getId()==party[j].getId()){
                    party[j].incrementId(1);
                }
            }
        }
        

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
        if(selectedCharacter == null){
            for (int i = 0; i < partyOrder.GetLength(0); i++)
            {
                if(partyOrder[i]!=null){
                    
                    SelectCharacter(partyOrder[i]);
                    ArrangeParty(i);
                }
            }
        }
        //
        if("a0" ==atk){
            if(skillActive !=true){
                if(currentCharacterIndex != getTargetedCharacterIndex(orderList[0].getId())){
                    SelectCharacter(orderList[0]);
                    ArrangeParty(0);
                }
            }else if(skillActive == true){
                
            }
        }
        if("a1" ==atk){
            if(skillActive !=true){
                if(currentCharacterIndex != getTargetedCharacterIndex(orderList[1].getId())){
                    SelectCharacter(orderList[1]);
                    ArrangeParty(1);

                }
            }else if(skillActive == true){
            }
        }
        if("a2" ==atk){
            if(skillActive !=true){
                if(currentCharacterIndex != getTargetedCharacterIndex(orderList[2].getId())){
                    SelectCharacter(orderList[2]);
                    ArrangeParty(2);

                }
            }else if(skillActive == true){
            }
        }
        if(party[0]==null&&party[1]==null&&party[2]==null){
            SceneManager.LoadScene("SampleScene");


        }
    }

    void ArrangeParty(int num){
        // partyOrder[getTargetedCharacterIndex(orderList[0].getId(num))]
        partyOrder[getTargetedCharacterIndex(orderList[num].getId())]=null;

        for (int i = partyOrder.GetLength(0)-1; i > 0; i--)
        {   
            Debug.Log(i);
            if(partyOrder[i]==null){
                partyOrder[i]=partyOrder[i-1];
                partyOrder[i-1]=null;
            }
        }
        partyOrder[0]= orderList[num];
        Debug.Log(partyOrder);
        for (int i = 0; i < partyOrder.GetLength(0); i++)
        {
            partyOrder[i].gameObject.GetComponent<Transform>().localPosition = new Vector2(0.2f*i,0f);
        }

    }
    public Character[] getPartyOrder(){
        return partyOrder;
    }
    public Character[] getParty(){
        return party;
    }
}
