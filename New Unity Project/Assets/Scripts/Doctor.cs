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
    float sleepTime = 1.0f;

    private Vector2 direction;
    private Transform target;
    private double yDist;
    private double xDist;
    private float newSpeed;
    private SpriteRenderer sprite;

    public Boolean hit = false;

    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.Find("Player").transform;
        sprite = GetComponent<SpriteRenderer>();
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
            //speed = 0;
            
        }
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

    void Approach()
    {
        transform.Translate(direction * newSpeed * Time.deltaTime);
    }

    void sleep()
    {
        hit = true;
        StartCoroutine(StayDown());
    }

    private IEnumerator StayDown()
    {

        yield return new WaitForSeconds(sleepTime);
        hit = false;
    }
}
