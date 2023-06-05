using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{

    private EnemyManager enemyManager;
    [SerializeField] private GameObject youDiedScreen;

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
            yield return new WaitForSeconds(60);

            enemyManager.spawnTime /= 2;

            if (enemyManager.spawnTime < 1)
            {
                StopAllCoroutines();
            }

        }

    }

    public void Lose()
    {
        youDiedScreen.SetActive(true);
    }

    public void ReturnToMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }

}
