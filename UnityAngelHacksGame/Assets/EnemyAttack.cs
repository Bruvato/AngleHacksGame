using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private BattleManager battleManager;
    [SerializeField] private Character enemyCharacter;
    [SerializeField] private List<Skill> enemySkills;
    [SerializeField] private UseSkill useSkill;
    [SerializeField] private Character caster;
    void Awake()
    {
        
    }
    
    // Update is called once per frame
    void Update()
    {
        if(enemyCharacter.getCurrentStam()==100){
            AttackLoop(enemySkills[0]);
            
        }
    }
    void AttackLoop(Skill skill){
        enemyCharacter.reduceStamina(100);
        useSkill.Cast(caster, battleManager.getPartyOrder()[0], skill);
        
    }
}
