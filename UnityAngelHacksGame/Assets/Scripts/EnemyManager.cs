using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    [SerializeField] public GameObject[] enemies;
    [SerializeField] Transform[] spawnpoints;
    [SerializeField] public float spawnTime;
    [SerializeField] private float enemyCap;
    private void Start()
    {
        StartCoroutine(SpawnEnemy());
    }

    IEnumerator SpawnEnemy()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnTime);

            Instantiate(enemies[Random.Range(0, enemies.Length)], spawnpoints[Random.Range(0, spawnpoints.Length)]);
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        foreach (Transform sp in spawnpoints)
        {
            Gizmos.DrawWireSphere(sp.position, 0.1f);
        }
    }


}
