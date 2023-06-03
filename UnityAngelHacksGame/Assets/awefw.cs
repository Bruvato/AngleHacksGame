using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class awefw : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject obj;
    [SerializeField] private Character ooo;

    void Start()
    {
        if(ooo.GetHp()<=0)
        obj.active=true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
