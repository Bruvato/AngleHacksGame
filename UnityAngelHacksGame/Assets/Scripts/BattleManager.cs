using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class BattleManager : MonoBehaviour
{
    private Dictionary<int, Character> orderList;//character, id
    // [SerializeField]private ButtonManager bManager;
    // Start is called before the first frame update
    // private 

    [SerializeField] private Character[] party = new Character[3];
    [SerializeField] private Character[] partyOrder = new Character[3];

    [SerializeField] private Character selectedCharacter;
    [SerializeField] private int selectedCharacterId, currentCharacterIndex;
    private bool skillActive;
    private Skill selectedSkill;
    [SerializeField]private Image highResImg;

    public void SelectSkill(Skill action)
    {
        selectedSkill = action;
    }
    public void SelectCharacter(Character target)
    {
        currentCharacterIndex = getSelectedCharacterIndex();
        selectedCharacter = target;
        selectedCharacterId = target.getId();



    }
    public int getSelectedCharacterIndex()
    {
        for (int i = 0; i < party.GetLength(0); i++)
        {

            if (party[i].getId() == selectedCharacterId)
            {
                Debug.Log(i);

                return i;
            }

        }
        return 0;
    }
    public int getTargetedCharacterIndex(int id)
    {
        for (int i = 0; i < party.GetLength(0); i++)
        {
            if (party[i].getId() == id)
            {
                return i;
            }

        }
        return 0;
    }
    void Awake()
    {
        orderList = new Dictionary<int, Character>();
        int count = 0;
        partyOrder = party;
        selectedCharacterId = partyOrder[0].getId();
        foreach (Character c in party)
        {
            Debug.Log(c);
            Debug.Log(count);

            orderList.Add(count, c);
            count++;
        }

        currentCharacterIndex = 0;

        skillActive = false;
        SelectCharacter(partyOrder[0]);
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
        highResImg.sprite = selectedCharacter.avatar;
        

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            if (skillActive != true)
            {
                // Debug.Log(currentCharacterIndex);
                if (currentCharacterIndex != getTargetedCharacterIndex(orderList[0].getId()))
                {

                    SelectCharacter(orderList[0]);
                    ArrangeParty(0);
                }
            }
            else if (skillActive == true)
            {

            }
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {

            if (skillActive != true)
            {
                Debug.Log(getTargetedCharacterIndex(orderList[1].getId()));
                if (currentCharacterIndex != getTargetedCharacterIndex(orderList[1].getId()))
                {

                    SelectCharacter(orderList[1]);
                    ArrangeParty(1);

                }
            }
            else if (skillActive == true)
            {
            }
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            if (skillActive != true)
            {
                if (currentCharacterIndex != getTargetedCharacterIndex(orderList[2].getId()))
                {
                    SelectCharacter(orderList[2]);
                    ArrangeParty(2);

                }
            }
            else if (skillActive == true)
            {
            }
        }


        if(Input.GetKeyDown(KeyCode.A)){
            partyOrder[0].allyAttack.AttackLoop(partyOrder[0].allyAttack.skills[0]);
            
        }
        if(Input.GetKeyDown(KeyCode.S)){
            // if(partyOrder[0].allyAttack.skills[1]!=null)
            partyOrder[0].allyAttack.AttackLoop(partyOrder[0].allyAttack.skills[1]);
            
            
        }
        if(Input.GetKeyDown(KeyCode.D)){
            // partyOrder[0].allyAttack.AttackLoop(partyOrder[0].allyAttack.skills[0]);
            
        }
    }

    void ArrangeParty(int num)
    {
        // partyOrder[getTargetedCharacterIndex(orderList[0].getId(num))]
        partyOrder[getTargetedCharacterIndex(orderList[num].getId())] = null;

        for (int i = partyOrder.GetLength(0) - 1; i > 0; i--)
        {
            Debug.Log(i);
            if (partyOrder[i] == null)
            {
                partyOrder[i] = partyOrder[i - 1];
                partyOrder[i - 1] = null;
            }
        }
        partyOrder[0] = orderList[num];
        Debug.Log(partyOrder);
        for (int i = 0; i < partyOrder.GetLength(0); i++)
        {
            if (partyOrder[i] != null)
            {
                partyOrder[i].gameObject.GetComponent<Transform>().localPosition = new Vector2(-0.2f * i, 0f);
            }
        }
    }
    public Character[] getPartyOrder()
    {
        return partyOrder;
    }
    public Character[] getParty()
    {
        return party;
    }
    public Character getSelected()
    {
        return selectedCharacter;
    }
}
