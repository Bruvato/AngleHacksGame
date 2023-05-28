using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    [SerializeField] private HeroData heroData;
    // Start is called before the first frame update
    private int trueMaxHp, currentHp, trueMaxStam, currentStam;
    void Awake(){
        trueMaxHp = heroData.maxHp;
        currentHp = trueMaxHp;
        trueMaxStam = heroData.maxStam;
        currentStam = trueMaxStam;
    }
    // Update is called once per frame
    
    void Update()
    {
        currentStam += (int)Mathf.Round(heroData.vit*Time.deltaTime);
        if(currentStam>trueMaxStam){
            currentStam = trueMaxStam;
        }

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
}
