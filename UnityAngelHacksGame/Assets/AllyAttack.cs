using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllyAttack : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private BattleManager battleManager;
    [SerializeField] private EnemyBattleManager enemyBattleManager;

    [SerializeField] private Character enemyCharacter;
    [SerializeField] private List<SkillData> Skills;
    [SerializeField] private UseSkill UseSkill;
    [SerializeField]private static bool onCoolDown, toggle;
    [SerializeField]public string attack;
    public static int c = 0;

    void Awake()
    {
        attack = "a"+c;
        c++;
        onCoolDown =false;
        toggle = false;
    }
    
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A)){
            
            AttackLoop(Skills[0]);

        }
        if(Input.GetKeyDown(KeyCode.B)){
            // AttackLoop(Skills[1]);

        }
    }
    private static IEnumerator CoolDown(float cd){
        toggle = true;
        onCoolDown =true;
        Debug.Log("cooldown");
        WaitForSeconds wait = new WaitForSeconds(cd);
        yield return wait;
        Debug.Log("offcd");
        onCoolDown =false;
        toggle = false;
    }
    void AttackLoop(SkillData skill){
        

        if(onCoolDown != true){
            onCoolDown =true;
            Debug.Log(enemyCharacter);
            enemyCharacter.reduceStamina(100);
            UseSkill.Cast(enemyCharacter, enemyBattleManager.getPartyOrder()[0], skill);

            
        } else if (toggle ==false){
            
            StartCoroutine(CoolDown(1));

        }
    }
}
