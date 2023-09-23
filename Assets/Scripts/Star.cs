using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star : MonoBehaviour
{
    private Animator anim;

    private void Awake()
    {
        anim = GetComponent<Animator>();
    }

    public void PlayAnim()
    {
        anim.SetTrigger("Scale");
        gameObject.GetComponent<BoxCollider2D>().enabled = false;
    }
}
