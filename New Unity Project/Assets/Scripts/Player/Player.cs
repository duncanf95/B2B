using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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

    [SerializeField]
    float health = 100;

    public bool hit = false;


    private Vector2 direction;
    private Slider HealthBar;




    // Start is called before the first frame update
    void Start()
    {
        //RectTransform rt = (RectTransform)transform;
        xMin += GetComponent<SpriteRenderer>().bounds.size.x / 2;
        xMax -= GetComponent<SpriteRenderer>().bounds.size.x / 2;

        yMin += GetComponent<SpriteRenderer>().bounds.size.y / 2;
        yMax -= GetComponent<SpriteRenderer>().bounds.size.y / 2;

        HealthBar = GameObject.Find("HealthBar").GetComponent<Slider>();

    }

    // Update is called once per frame
    void Update()
    {
        GetInput();
        CheckBoundaries();
        Move();
        if (HealthBar)
        {
            HealthBar.value = health;
        }

    }

    public void Move()
    {
        transform.Translate(direction * speed * Time.deltaTime);
    }

    private void GetInput()
    {
        if (!hit)
        {
            direction = Vector2.zero;
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

    private void CheckBoundaries()
    {
        
        //transform.position = new Vector3(Mathf.Clamp(transform.position.x, xMin, xMax),
                                        //Mathf.Clamp(transform.position.y, yMin, yMax),
                                       // transform.position.z);
    }

    public void DecreaseHealth(float d)
    {
        health -= d;
        if(health <= 0)
        {
            health = 0;
            Application.LoadLevel("B2B");
        }
    }

    public void increaseHealth(float d)
    {
        health += d;
        if (health > 100)
        {
            health = 100;
        }
    }
}
