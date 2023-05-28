using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectSkill : MonoBehaviour
{
    [SerializeField] private BattleManager bManager;
    private Skill ski;

    // Start is called before the first frame update
    void Start()
    {
        ski = gameObject.GetComponent<Skill>();        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void bManagerSkill(){
        bManager.SelectSkill(ski);
    }
}
