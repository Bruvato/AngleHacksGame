using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseSkill : MonoBehaviour
{
    private Character heroStats;
    
    // Start is called before the first frame update
    void Awake()
    {

    }
    public void Cast(Character user,Character target, Skill skill)
    {
        
        target.reduceHp((int)Mathf.Round(heroStats.getAtk()*skill.atkmult));

    }

    // Update is called once per frame
    void Update()
    {

    }
}
