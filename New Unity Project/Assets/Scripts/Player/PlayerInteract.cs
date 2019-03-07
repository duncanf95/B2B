using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteract : MonoBehaviour {

    // Use this for initialization

    private GameObject co = null;
	private string tag = null;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && co && tag == "Door")
        {
            co.SendMessage("Open");
            gameObject.GetComponent<Inventory>().test = 12;
        }

        if (Input.GetKeyDown(KeyCode.E) && co && tag == "Metal Door")
        {
            Debug.Log("at metal door");

            foreach (KeyInventoryInfo key in gameObject.GetComponent<Inventory>().keys)
            {
                if (checkKey(co.GetComponent<InteractionObject>().identifier, key.door))
                {
                    co.SendMessage("Open");
                }


            }
        }

        if (Input.GetKeyDown(KeyCode.E) && co && tag == "Key")
        {
            gameObject.GetComponent<Inventory>().addKey(
                co.GetComponent<KeyInventoryInfo>());
            co.SendMessage("PickUp");

        }
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Door") )
        {
            co = collision.gameObject;
			tag = "Door";
        }

        if (collision.CompareTag("Metal Door"))
        {
            co = collision.gameObject;
            tag = "Metal Door";
        }

        if (collision.CompareTag("Key"))
		{
			co = collision.gameObject;
			tag = "Key";
		}
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Door") || collision.CompareTag("Metal Door"))
        {
            if(co == collision.gameObject) 
            {
                //co.SendMessage("Close");
                co = null;
				tag = null;
                
            }
        }
    }

    private bool checkKey(string tag1, string tag2)
    {
        Debug.Log(tag1);
        Debug.Log(tag2);
        if (tag1 == tag2)
        {
            return true;
        }
        return false;
    }
}
