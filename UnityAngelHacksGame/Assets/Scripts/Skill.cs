using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skill : MonoBehaviour
{
    [SerializeField]private SkillData skillData;
    public float atkMult, defMult, healMult, lifestealMult, debuffMult;
    private string skillName;
    // Start is called before the first frame update
    void Start()
    {

        skillName = skillData.skillName;
        atkMult = skillData.atkmult;
        defMult = skillData.defmult;
        healMult = skillData.healmult;
        lifestealMult = skillData.lifestealmult;
        debuffMult = skillData.debuffmult;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
