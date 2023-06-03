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
        
        user.reduceHp((int)Mathf.Round(-1*user.getAtk()*skill.healmult));

        user.reduceHp((int)Mathf.Round(-1*user.getAtk()*skill.lifestealmult));

        if(skill.fullblock ==true){
            StartCoroutine(Block(user, 2));
        }
        
    }
    private IEnumerator Block(Character target, float time){
        float hp = target.GetHp();
        bool blocking = true;
        WaitForSeconds wait = new WaitForSeconds(time);
        while(blocking == true){
            target.SetHp(100);
            yield return wait;
            target.SetHp(hp);
            blocking = false;
            
            
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
