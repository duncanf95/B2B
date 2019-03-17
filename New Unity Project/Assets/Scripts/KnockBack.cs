using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KnockBack : MonoBehaviour
{
    [SerializeField]
    private float knockback;
    [SerializeField]
    private float knocktime;

    public Slider HealthBar;

    // Start is called before the first frame update
    void Start()
    {
        HealthBar = GameObject.Find("HealthBar").GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {

    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (gameObject.CompareTag("Enemy"))
        {

            if (collision.gameObject.CompareTag("Player"))
            {

                Rigidbody2D enemy = collision.GetComponent<Rigidbody2D>();
               
                if (enemy != null)
                {
                    gameObject.GetComponent<Doctor>().sleep();
                    Player p = collision.GetComponent<Player>();
                    p.DecreaseHealth(25);
                    playerknockback(enemy);
                }
            }
        }


        if (gameObject.CompareTag("Axe"))
        {
            if (collision.gameObject.CompareTag("Enemy"))
            {


                Rigidbody2D enemy = collision.GetComponent<Rigidbody2D>();
                if (enemy != null)
                {
                    //enemyknockback(enemy);
                    collision.GetComponent<Doctor>().sleep();
                    gameObject.GetComponent<Swing>().triggered = true;
                    gameObject.GetComponent<Swing>().enemy = enemy;
                }

            }

            if (collision.gameObject.CompareTag("Wooden Door"))
            {

                gameObject.GetComponent<Swing>().triggered = true;
                gameObject.GetComponent<Swing>().door = collision.gameObject;

            }





            }

        }
    

    private void OnTriggerExit2D(Collider2D collision)
    {
        Rigidbody2D enemy = collision.GetComponent<Rigidbody2D>();
        if (gameObject.CompareTag("Axe"))
        {
            gameObject.GetComponent<Swing>().triggered = false;
            gameObject.GetComponent<Swing>().enemy = null;
        }
    }


    public void playerknockback(Rigidbody2D enemy)
    {
        Vector2 difference = enemy.transform.position - transform.position;
        difference = difference.normalized * knockback;
        //enemy.GetComponent<Player>().hit = true;
        enemy.AddForce(difference, ForceMode2D.Impulse);
        StartCoroutine(KnockCo(enemy));
    }

    public void enemyknockback(Rigidbody2D enemy)
    {
        Vector2 difference = enemy.transform.position - transform.position;
        difference = difference.normalized * knockback;
       //enemy.GetComponent<Doctor>().hit = true;
        enemy.AddForce(difference, ForceMode2D.Impulse);
        StartCoroutine(KnockCo(enemy));
    }

    public void destoryDoor(GameObject door)
    {
        door.SetActive(false);
    }


    private IEnumerator KnockCo(Rigidbody2D enemy)
    {
        if(enemy != null)
        {
            yield return new WaitForSeconds(knocktime);
            enemy.velocity = Vector2.zero;
        }
    }
}
