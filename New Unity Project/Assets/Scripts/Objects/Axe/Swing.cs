﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swing : MonoBehaviour
{
    public Animator animAxe;
    public Rigidbody2D enemy;
    public GameObject egg;
    public bool triggered;
    AxeInventoryInfo axe;
    public GameObject door;
    [SerializeField]
    private float axeOutTime = 0.5f;
    
    // Start is called before the first frame update
    void Start()
    {
        animAxe = GetComponent<Animator>();
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
                            gameObject.GetComponent<SpriteRenderer>().sortingLayerName = "Objects";
                            StartCoroutine(outTimer());
                            Debug.Log("Swing");
                            animAxe.Play("AxeSwing");
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
                            animAxe.Play("AxeSwing");
                        }
                    }
                }
                
            }
        }
        if (axe != null)
        {
            if (axe.selected)
            {
                if (egg != null)
                {
                    Debug.Log("Swing");
                    animAxe.Play("AxeSwing");
                }
            }
        }

        if (Input.GetButtonDown("Fire2"))
        {
            if (axe.selected)
            {
                gameObject.GetComponent<SpriteRenderer>().sortingLayerName = "Objects";
                StartCoroutine(outTimer());
            }
        }
    }

    private IEnumerator outTimer()
    {
        yield return new WaitForSeconds(axeOutTime);
        gameObject.GetComponent<SpriteRenderer>().sortingLayerName = "Default";
    }


}
