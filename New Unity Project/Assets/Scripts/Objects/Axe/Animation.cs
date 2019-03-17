using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation : MonoBehaviour
{
    private Animator animator;
    private BoxCollider2D B2D;
    // Start is called before the first frame update
    void Start()
    {
        animator = gameObject.GetComponent<Animator>();
    
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire2"))
        {
            Swing();
        }

        if (Input.GetButtonUp("Fire2"))
        {
            Stop();
        }
    }

    public void Swing()
    {
        animator.SetBool("NotSwing", false);
        animator.SetBool("Swing", true);
        //animator.SetBool("Swing", false);
        //animator.SetBool("NotSwing", true);


    }

    public void Stop()
    {
        animator.SetBool("Swing", false);
        animator.SetBool("NotSwing", true);
    }
}
