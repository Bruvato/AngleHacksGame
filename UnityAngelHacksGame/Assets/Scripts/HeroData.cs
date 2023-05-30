using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "HeroData", menuName = "~/HeroData", order = 0)]
public class HeroData : ScriptableObject
{
    public bool isEnemy;
    public string heroName;
    public int maxHp, maxStam;
    public int atk, def, vit, heroId;
    public int characterId;
    public Sprite highRes, front, right, left, back;
    public GameObject battleCanvas;
    


}