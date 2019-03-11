using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackPositionAxe : MonoBehaviour
{
    // Start is called before the first frame update
    private Vector2 direction;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        UpdateDirection();
    }

    private void UpdateDirection()
    {
        //direction = Vector2.zero;
        checkInputs();

        if (direction.x > 0 && direction.y > 0)
        {
            if (Math.Truncate(gameObject.transform.rotation.eulerAngles.z) != 315)
            {
                gameObject.transform.Rotate(0, 0, 45);
            }
        }
        else if (direction.x > 0 && direction.y < 0)
        {
            if (Math.Truncate(gameObject.transform.rotation.eulerAngles.z) != 225)
            {
                gameObject.transform.Rotate(0, 0, 45);
            }
        }
        else if (direction.x < 0 && direction.y < 0)
        {
            if (Math.Truncate(gameObject.transform.rotation.eulerAngles.z) != 135)
            {
                gameObject.transform.Rotate(0, 0, 45);
            }
        }
        else if (direction.x < 0 && direction.y > 0)
        {
            if (Math.Truncate(gameObject.transform.rotation.eulerAngles.z) != 45)
            {
                gameObject.transform.Rotate(0, 0, 45);
            }
        }

        if (direction.x > 0 && direction.y == 0)
        {
            if (Math.Truncate(gameObject.transform.rotation.eulerAngles.z) != 270)
            {
                gameObject.transform.Rotate(0, 0, 45);
            }
        }
        else if (direction.x == 0 && direction.y < 0)
        {
            if (Math.Truncate(gameObject.transform.rotation.eulerAngles.z) != 180)
            {
                gameObject.transform.Rotate(0, 0, 45);
            }
        }
        else if (direction.x < 0 && direction.y == 0)
        {
            if (Math.Truncate(gameObject.transform.rotation.eulerAngles.z) != 90)
            {
                gameObject.transform.Rotate(0, 0, 45);
            }
        }
        else if (direction.x == 0 && direction.y > 0)
        {
            if (Math.Truncate(gameObject.transform.rotation.eulerAngles.z) != 0)
            {
                gameObject.transform.Rotate(0, 0, 45);
            }
        }
    }

    private void checkInputs()
    {
        //direction = Vector2.zero;
        direction = new Vector2(Input.GetAxis("MoveHorizontal"), Input.GetAxis("MoveVertical"));

        if (Input.GetKey(KeyCode.W))
        {
            direction += Vector2.up;
        }

        if (Input.GetKey(KeyCode.S))
        {
            direction += Vector2.down;
        }

        if (Input.GetKey(KeyCode.D))
        {
            direction += Vector2.right;
        }

        if (Input.GetKey(KeyCode.A))
        {
            direction += Vector2.left;
        }
    }
}   
