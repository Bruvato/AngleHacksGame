using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseSkill : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Awake()
    {

    }
    public void Cast(Character user, Character target, SkillData skill)
    {
        
        target.reduceHp((int)Mathf.Round(user.getAtk()*skill.atkmult));

    }

    // Update is called once per frame
    void Update()
    {

    }
}
