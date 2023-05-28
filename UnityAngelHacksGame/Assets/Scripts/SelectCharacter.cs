using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectCharacter : MonoBehaviour
{
    [SerializeField] private BattleManager bManager;
    private Character cha;
    // Start is called before the first frame update
    void Awake()
    {
        cha = gameObject.GetComponent<Character>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown() {
        bManager.SelectCharacter(cha);

    }
}
