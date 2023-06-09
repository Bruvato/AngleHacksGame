using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.GetComponent<EnemyController>() != null)
        {
            other.gameObject.GetComponent<EnemyStats>().TakeDmg(10);

        }
        StartCoroutine(DestroyProj());
    }

    IEnumerator DestroyProj()
    {
        yield return new WaitForSeconds(2);
        Destroy(gameObject);
    }
}
