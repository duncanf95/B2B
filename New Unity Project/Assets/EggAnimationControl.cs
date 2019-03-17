using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EggAnimationControl : MonoBehaviour
{
    public Animator anim;
    private double yDist;
    private double xDist;
    private Transform target;
    private bool Hatched;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        target = GameObject.Find("Player").transform;
        Hatched = false;
    }

    // Update is called once per frame
    void Update()
    {
        //Is the player within radius of the egg
        yDist = Math.Abs(transform.position.y - target.position.y);
        xDist = Math.Abs(transform.position.x - target.position.x);

        if (xDist < 1.5 && yDist < 1.5)
        {
            if (!Hatched)
            {
                Hatched = true;
                anim.Play("EggHatch");
            }
        }
        if (xDist < 0.5 && yDist < 0.5)
        {

            if (Input.GetButton("Fire2"))
            {
                anim.Play("EggDead");
            }
        }
    }
}