using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shop_trigger : MonoBehaviour
{
    [SerializeField] private Animator animator;
    private void OnTriggerEnter2D(Collider2D other)
    {
        animator.SetBool("shopOpen", true);
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        animator.SetBool("shopOpen", false);

    }
}
