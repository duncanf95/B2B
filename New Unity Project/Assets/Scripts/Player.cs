using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private float speed;

    [SerializeField]
    private float xMax;
    [SerializeField]
    private float yMax;

    [SerializeField]
    private float xMin;
    [SerializeField]
    private float yMin;


    private Vector2 direction;



    // Start is called before the first frame update
    void Start()
    {
        //RectTransform rt = (RectTransform)transform;
        xMin += GetComponent<SpriteRenderer>().bounds.size.x / 2;
        xMax -= GetComponent<SpriteRenderer>().bounds.size.x / 2;

        yMin += GetComponent<SpriteRenderer>().bounds.size.y / 2;
        yMax -= GetComponent<SpriteRenderer>().bounds.size.y / 2;
    }

    // Update is called once per frame
    void Update()
    {
        GetInput();
        CheckBoundaries();
        Move();
        
    }

    public void Move()
    {
        transform.Translate(direction * speed * Time.deltaTime);
    }

    private void GetInput()
    {
        direction = Vector2.zero;
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

    private void CheckBoundaries()
    {
        
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, xMin, xMax),
                                        Mathf.Clamp(transform.position.y, yMin, yMax),
                                        transform.position.z);
    }
}
