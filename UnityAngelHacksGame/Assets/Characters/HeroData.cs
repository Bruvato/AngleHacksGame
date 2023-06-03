using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "HeroData", menuName = "~/HeroData", order = 0)]
public class HeroData : ScriptableObject
{
    public bool isEnemy;
    public string heroName;
    public float maxHp, maxStam;
    public float atk, def, vit;
    public int characterId, heroId;
    public Sprite highRes, front, right, left, back;
    public GameObject battleCanvas;
    


}