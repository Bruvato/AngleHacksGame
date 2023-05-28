using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField] private float spped;
    [SerializeField] private float range;
    [SerializeField] private float maxDist;

    [SerializeField] Animator animator;


    private Vector2 wayypoint;


    void Start()
    {
        SetNewDestLoc();
        animator.SetBool("isMoving", true);

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, wayypoint, spped * Time.deltaTime);
        if (Vector2.Distance(transform.position, wayypoint) < range)
        {
            SetNewDestLoc();

        }
        animator.SetFloat("horizontal", wayypoint.x - transform.position.x);
        animator.SetFloat("vertical", wayypoint.y - transform.position.y);

    }

    private void SetNewDestLoc()
    {
        wayypoint = new Vector2(Random.Range(-maxDist, maxDist), Random.Range(-maxDist, maxDist));

    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other);
    }


}
