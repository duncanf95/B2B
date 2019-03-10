using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class open_close : MonoBehaviour
{
    private Animator animator;
    private BoxCollider2D B2D;
    // Start is called before the first frame update
    void Start()
    {
        animator = gameObject.GetComponent<Animator>();
        B2D = gameObject.GetComponent <BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
     
    }

    public void Open()
    {
        animator.SetBool("Open", true);
        B2D.isTrigger = true;
    }
}
