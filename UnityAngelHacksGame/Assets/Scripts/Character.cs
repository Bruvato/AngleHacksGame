using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    [SerializeField] private HeroData heroData;
    

    // Start is called before the first frame update
    [SerializeField]private int trueMaxHp, currentHp, trueMaxStam, currentStam, characterId, level;
    void Awake(){
        trueMaxHp = heroData.maxHp;
        currentHp = trueMaxHp;
        trueMaxStam = heroData.maxStam;
        currentStam = trueMaxStam;
        characterId = heroData.heroId;
        
    }
    // Update is called once per frame
    
    void Update()
    {
        if(currentHp<0){
            Destroy(gameObject);
        }
        Debug.Log("stam regen");
        currentStam += (int)Mathf.Round(heroData.vit*Time.deltaTime+1);
        if(currentStam>trueMaxStam){
            currentStam = trueMaxStam;
        }

    }
    public int getId(){
        return characterId;
    }
    public int getAtk(){
        return heroData.atk;
    }
    public int getCurrentStam(){
        return currentStam;
    }

    public void reduceStamina(int amount){
        currentStam -= amount;
    }
    public void reduceHp(int amount){
        currentHp -= amount;
    }
    public void incrementId(int amount){
        characterId += amount;
    }
}
