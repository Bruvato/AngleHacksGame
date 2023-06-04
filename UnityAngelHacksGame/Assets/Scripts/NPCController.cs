using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCController : MonoBehaviour
{
    // Array of waypoints to walk from one to the next one
    [SerializeField]
    private Transform[] waypoints;

    // Walk speed that can be set in Inspector
    [SerializeField]
    private float moveSpeed = 2f;

    // Index of current waypoint from which Enemy walks
    // to the next one
    private int waypointIndex = 0;

    [SerializeField] Animator animator;

    [SerializeField] public bool isMoving;


    // Use this for initialization
    private void Start()
    {

        // Set position of Enemy as position of the first waypoint
        int i = Random.Range(0, waypoints.Length - 1);
        transform.position = waypoints[i].transform.position;
        waypointIndex = i;

        isMoving = true;
    }

    // Update is called once per frame
    private void Update()
    {
        isMoving = !GetComponent<DialogueTrigger>().dialogue.inConversation;
        animator.SetBool("isMoving", isMoving);

        // Move Enemy
        if (isMoving)
        {
            Move();
        }

        if (waypointIndex >= 0 && waypointIndex < waypoints.Length)
        {
            animator.SetFloat("horizontal", waypoints[waypointIndex].transform.position.x - transform.position.x);
            animator.SetFloat("vertical", waypoints[waypointIndex].transform.position.y - transform.position.y);
        }
    }

    // Method that actually make Enemy walk
    private void Move()
    {
        // If Enemy didn't reach last waypoint it can move
        // If enemy reached last waypoint then it stops
        if (waypointIndex < waypoints.Length)
        {

            // Move Enemy from current waypoint to the next one
            // using MoveTowards method
            transform.position = Vector2.MoveTowards(transform.position,
               waypoints[waypointIndex].transform.position,
               moveSpeed * Time.deltaTime);

            // If Enemy reaches position of waypoint he walked towards
            // then waypointIndex is increased by 1
            // and Enemy starts to walk to the next waypoint
            if (Mathf.Approximately(transform.position.x, waypoints[waypointIndex].transform.position.x) &&
            Mathf.Approximately(transform.position.y, waypoints[waypointIndex].transform.position.y)
            )
            {
                waypointIndex += 1;
            }
        }
        else
        {
            waypointIndex = 0;
        }
    }
    private void OnDrawGizmos()
    {
        foreach (Transform way in waypoints)
        {
            Gizmos.DrawWireSphere(way.position, 0.1f);
        }
    }
}
