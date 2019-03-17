using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swing : MonoBehaviour
{

    public Rigidbody2D enemy;
    public bool triggered;
    AxeInventoryInfo axe;
    public GameObject door;
    
    // Start is called before the first frame update
    void Start()
    {
        axe = GameObject.Find("Player").GetComponent<Inventory>().axe;
    }

    // Update is called once per frame
    void Update()
    {
        axe = GameObject.Find("Player").GetComponent<Inventory>().axe;
        if (triggered)
        {
            if (Input.GetButtonDown("Fire2"))
            {
                if (enemy != null)
                {
                    if (axe != null)
                    {
                        if (axe.selected)
                        {
                            gameObject.GetComponent<KnockBack>().enemyknockback(enemy);
                            Debug.Log("Swing");
                        }
                    }
                }

                if (axe != null)
                {
                    if (door != null)
                    {
                        
                        if (axe.selected)
                        {
                      
                            gameObject.GetComponent<KnockBack>().destoryDoor(door);
                            Debug.Log("Swing");
                        }
                    }
                }
            }
        }
    }


}
