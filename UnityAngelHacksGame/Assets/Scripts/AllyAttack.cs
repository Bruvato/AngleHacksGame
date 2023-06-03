using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllyAttack : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private BattleManager battleManager;
    [SerializeField] private EnemyBattleManager enemyBattleManager;

    [SerializeField] private Character allyCharacter;
    [SerializeField] public List<SkillData> skills;
    [SerializeField] private UseSkill UseSkill;
    [SerializeField]private static bool onCoolDown, toggle;
    [SerializeField]public string attack;
    public static int c = 0;
    private float target;

    void Awake()
    {
        attack = "a"+c;
        c++;
        onCoolDown =false;
        toggle = false;
        // target = 0;
    }
    
    // Update is called once per frame
    void Update()
    {
        
        // Lerper();
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
    public void AttackLoop(SkillData skill){
        

        if(onCoolDown != true){
            // onCoolDown =true;
            Debug.Log("allyAttack");
            // target = 1;
            if(allyCharacter.getCurrentStam()==100){
            allyCharacter.reduceStamina(100);
            UseSkill.Cast(allyCharacter, enemyBattleManager.getPartyOrder()[0], skill);
            if(skill.aoe ==true){
                if(enemyBattleManager.getPartyOrder()[1]!=null){
                UseSkill.Cast(allyCharacter, enemyBattleManager.getPartyOrder()[1], skill);
                }
                if(enemyBattleManager.getPartyOrder()[2]!= null){
                UseSkill.Cast(allyCharacter, enemyBattleManager.getPartyOrder()[2], skill);
                }
            }}
            
        } else if (toggle ==false){
            
            StartCoroutine(CoolDown(1));

        }
    }
    // public void Lerper(){

    //     current = Mathf.MoveTowards(current, target, speed);
    //     Vector2 og = new Vector2(gameObject.transform.position.x,gameObject.transform.position.y);
    //     Vector2 tgt = new Vector2(0,gameObject.transform.position.y);
    //     transform.position = new
    // }
}
