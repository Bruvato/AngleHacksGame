using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scroll : MonoBehaviour
{
    [SerializeField] private Animator animator;

    public void OnMouseDown()
    {

        animator.SetBool("isOpen", true);
        StartCoroutine(closeScroll());
    }

    IEnumerator closeScroll()
    {
        yield return new WaitForSeconds(3);
        animator.SetBool("isOpen", false);

    }
    public void OnMouseEnter()
    {
        GetComponent<SpriteRenderer>().color = Color.grey;
    }
    public void OnMouseExit()
    {
        GetComponent<SpriteRenderer>().color = Color.white;

    }

}
