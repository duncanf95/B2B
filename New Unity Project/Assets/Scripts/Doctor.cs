using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doctor : MonoBehaviour
{
    [SerializeField]
    private float speed;

    private Vector2 direction;
    private Transform target;
    private double yDist;
    private double xDist;

    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.Find("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        HuntTarget();
    }

    void HuntTarget()
    {
        //Is the player within radius of the enemy?
        yDist = Math.Abs(transform.position.y - target.position.y);
        xDist = Math.Abs(transform.position.x - target.position.x);
        //If so close the gap
        direction = Vector2.zero;
        if (xDist < 1.5 && yDist < 1.5)
        {
            if (transform.position.y < target.position.y)
            {
                direction += Vector2.up;
                Approach();
            }
            if (transform.position.y > target.position.y)
            {
                direction += Vector2.down;
                Approach();
            }
            if (transform.position.x < target.position.x)
            {
                direction += Vector2.right;
                Approach();
            }
            if (transform.position.x > target.position.x)
            {
                direction += Vector2.left;
                Approach();
            }
        }
        
    }

    void Approach()
    {
        transform.Translate(direction * speed * Time.deltaTime);
    }
}
