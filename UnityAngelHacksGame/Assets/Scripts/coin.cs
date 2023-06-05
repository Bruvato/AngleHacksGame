using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Player")
        {
            Destroy(gameObject);
            FindObjectOfType<MoneyManager>().money++;
        }
    }

    private void Start()
    {
        StartCoroutine(DestroyCoin());
    }

    IEnumerator DestroyCoin()
    {
        yield return new WaitForSeconds(10);
        Destroy(gameObject);
    }

}
