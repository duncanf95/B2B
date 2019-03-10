using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Doctor : MonoBehaviour
{
    [SerializeField]
    private float speed;

    [SerializeField]
    private float knock;

    private Vector2 direction;
    private Vector2 knockback;
    private Transform target;
    private double yDist;
    private double xDist;
    private float newSpeed;
    private SpriteRenderer sprite;
    public Slider HealthBar;

    public Boolean hit = false;

    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.Find("Player").transform;
        sprite = GetComponent<SpriteRenderer>();
        HealthBar = GameObject.Find("HealthBar").GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!hit)
        {
            HuntTarget();
        }
        else
        {
            speed = 0;
            
        }
        //AttackTarget();
    }

    void HuntTarget()
    {
        //Is the player within radius of the enemy?
        yDist = Math.Abs(transform.position.y - target.position.y);
        xDist = Math.Abs(transform.position.x - target.position.x);
        //If so close the gap
        direction = Vector2.zero;
        newSpeed = speed;
        if (xDist < 1.5 && yDist < 1.5)
        {
            if (transform.position.y < target.position.y - 0.25)
            {
                sprite.sortingLayerName = "EnemyFront";
                direction += Vector2.up;
                if (transform.position.x > target.position.x - 0.3 && transform.position.x < target.position.x + 0.3)
                {
                    newSpeed = speed * 2;
                    Approach();
                    newSpeed = speed;
                }
                else
                {
                    Approach();
                }
            }
            if (transform.position.y > target.position.y + 0.4)
            {
                sprite.sortingLayerName = "EnemyBehind";
                direction += Vector2.down;
                if (transform.position.x > target.position.x - 0.3 && transform.position.x < target.position.x + 0.3)
                {
                    newSpeed = speed * 2;
                    Approach();
                    newSpeed = speed;
                }
                else
                {
                    Approach();
                }
            }
            if (transform.position.x < target.position.x - 0.3)
            {
                direction += Vector2.right;
                if (transform.position.y > target.position.y - 0.4 && transform.position.y < target.position.y + 0.25)
                {
                    newSpeed = speed * 2;
                    Approach();
                    newSpeed = speed;
                }
                else
                {
                    Approach();
                }
            }
            if (transform.position.x > target.position.x + 0.3)
            {
                direction += Vector2.left;
                if (transform.position.y > target.position.y - 0.4 && transform.position.y < target.position.y + 0.25)
                {
                    newSpeed = speed * 2;
                    Approach();
                    newSpeed = speed;
                }
                else
                {
                    Approach();
                }
            }
        }
    }

    void AttackTarget()
    {
        //Is the player within range of attack?
        yDist = Math.Abs(transform.position.y - target.position.y);
        xDist = Math.Abs(transform.position.x - target.position.x);
        //If so hit him
        if (xDist < 0.3 && yDist < 0.4)
        {
            HealthBar.value -= 25;
            if (transform.position.y < target.position.y)
            {
                knockback = target.position;
                knockback.y += (float)0.3;
                target.position = knockback;
            }
            if (transform.position.y > target.position.y)
            {
                knockback = target.position;
                knockback.y -= (float)0.3;
                target.position = knockback;
            }
            if (transform.position.x < target.position.x)
            {
                knockback = target.position;
                knockback.x += (float)0.3;
                target.position = knockback;
            }
            if (transform.position.x > target.position.x)
            {
                knockback = target.position;
                knockback.x -= (float)0.3;
                target.position = knockback;
            }
        }
    }

    void Approach()
    {
        transform.Translate(direction * newSpeed * Time.deltaTime);
    }

   
}
