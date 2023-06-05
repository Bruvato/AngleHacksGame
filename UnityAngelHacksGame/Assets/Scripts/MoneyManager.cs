using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MoneyManager : MonoBehaviour
{
    public float money;
    [SerializeField] private TextMeshProUGUI tmp;
    [SerializeField] public GameObject coin;

    private void Update()
    {
        tmp.text = money + "";
    }


}
