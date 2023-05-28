using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleManager : MonoBehaviour
{
    [SerializeField]private ButtonManager bManager;
    // Start is called before the first frame update
    // private 
    private Character selectedCharacter;
    private Skill selectedSkill;

    public void SelectSkill(Skill action){
        selectedSkill = action;
    }
    public void SelectCharacter(Character target){
        selectedCharacter = target;
    
    }
    void Awake()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
