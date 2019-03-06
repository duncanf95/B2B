using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteract : MonoBehaviour {

    // Use this for initialization

    private GameObject co = null;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && co)
        {
            co.SendMessage("Open");
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Door"))
        {
            co = collision.gameObject;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Door"))
        {
            if(co == collision.gameObject) 
            {
                //co.SendMessage("Close");
                co = null;
                
            }
        }
    }
}
