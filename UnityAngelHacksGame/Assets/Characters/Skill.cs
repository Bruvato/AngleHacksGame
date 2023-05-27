using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "Skill", menuName = "~/Skill", order = 0)]
public class Skill : ScriptableObject {

    public string skillName;
    public float atkmult = 0f;
    public float defmult = 0f;
    public float healmult = 0f;
    public float lifestealmult = 0f;
    public float debuffmult = 0f;
    
    
}
