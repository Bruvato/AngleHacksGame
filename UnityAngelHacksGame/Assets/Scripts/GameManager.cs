using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{

    private EnemyManager enemyManager;

    private void Awake()
    {
        enemyManager = FindObjectOfType<EnemyManager>().GetComponent<EnemyManager>();
    }

    private void Start()
    {
        StartCoroutine(IncDiff());
    }

    IEnumerator IncDiff()
    {
        while (true)
        {
            yield return new WaitForSeconds(30);

            enemyManager.spawnTime /= 2;

        }

    }

    public void Lose()
    {
        Debug.Log("GAME OVER");
    }

}
