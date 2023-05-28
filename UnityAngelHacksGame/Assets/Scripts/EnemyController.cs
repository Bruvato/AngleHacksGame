using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField] private float spped;
    [SerializeField] private float range;
    [SerializeField] private float maxDist;

    private Vector2 wayypoint;


    void Start()
    {
        SetNewDestLoc();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, wayypoint, spped * Time.deltaTime);
        if (Vector2.Distance(transform.position, wayypoint) < range)
        {
            SetNewDestLoc();

        }
    }

    private void SetNewDestLoc()
    {
        wayypoint = new Vector2(Random.Range(-maxDist, maxDist), Random.Range(-maxDist, maxDist));

    }
    void OnTriggerEnter(Collider collider)
    {
        Debug.Log("enemy collided");
    }


}
