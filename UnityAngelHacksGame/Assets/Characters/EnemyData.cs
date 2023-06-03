using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "EnemyData", menuName = "~/EnemyData", order = 0)]
public class EnemyData : ScriptableObject
{
    public string EnemyName;
    public float maxHp, maxStam;
    public float atk, def, vit, EnemyId;
    public int characterId;
    public Sprite highRes, front, right, left, back;
    public GameObject battleCanvas;
    


}