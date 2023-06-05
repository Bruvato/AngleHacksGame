using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private bool chasing;
    private Transform player;
    [SerializeField] private Animator animator;
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private float moveSpeed;

    private void OnBecameVisible()
    {
        chasing = true;
    }

    private void OnBecameInvisible()
    {
        chasing = false;
    }

    private void Start()
    {
        player = FindObjectOfType<PlayerController>().gameObject.transform;
    }
    private void Update()
    {
        animator.SetFloat("horizontal", rb.velocity.x);
        animator.SetFloat("vertical", rb.velocity.y);

        if (chasing)
        {
            rb.AddForce((player.position - transform.position) * moveSpeed, ForceMode2D.Force);
            //transform.position = Vector2.MoveTowards(transform.position, player.position, moveSpeed * Time.deltaTime);
        }

    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.name == "Player")
        {
            Destroy(gameObject);
            other.gameObject.GetComponent<PlayerStats>().TakeDmg(10);
        }
    }

}
