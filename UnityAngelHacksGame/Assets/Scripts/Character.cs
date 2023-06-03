using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Character : MonoBehaviour
{
    [SerializeField] private HeroData heroData;
    [SerializeField] public AllyAttack allyAttack;
    [SerializeField] private Image[] hpBar;
    [SerializeField] private Image[] stamBar;
    [SerializeField] public Canvas[] UI;
    public Sprite avatar; 
    [SerializeField] public bool invincible;
    [SerializeField] private int characterId;
    // Start is called before the first frame update
    [SerializeField]private float trueMaxHp, currentHp, trueMaxStam, currentStam, level;
    
    
    void Awake(){
        trueMaxHp = heroData.maxHp;
        currentHp = trueMaxHp;
        trueMaxStam = heroData.maxStam;
        currentStam = trueMaxStam;
        characterId = heroData.heroId;
        avatar = heroData.highRes;
    }
    // Update is called once per frame
    
    void Update()
    {
        foreach (Image bar in hpBar)
        {
            bar.fillAmount = currentHp/trueMaxHp;
        }
        foreach (Image bar in stamBar)
        {
            bar.fillAmount = currentStam/trueMaxStam;
        }
        if(currentHp<0){
            Destroy(gameObject);
        }
        Debug.Log("stam regen");
        currentStam += heroData.vit*Time.deltaTime*3;
        if(currentStam>trueMaxStam){
            currentStam = trueMaxStam;
        }
        

    }
    public int getId(){
        return characterId;
    }
    public float getAtk(){
        return heroData.atk;
    }
    public float GetHp(){
        return currentHp;
    }
    public void SetHp(float amount){
        currentHp = amount;
    }
    public float getCurrentStam(){
        return currentStam;
    }

    public void reduceStamina(float amount){
        currentStam -= amount;
    }
    public void reduceHp(float amount){
        currentHp -= amount;
    }
    public void incrementId(int amount){
        characterId += amount;
    }
}
