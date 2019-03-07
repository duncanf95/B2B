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
        }

		if (Input.GetKeyDown(KeyCode.E) && co && tag == "Key")
		{
			co.SendMessage("PickUp");
		}
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Door"))
        {
            co = collision.gameObject;
			tag = "Door";
        }

		if (collision.CompareTag("Key"))
		{
			co = collision.gameObject;
			tag = "Key";
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
				tag = null;
                
            }
        }
    }
}
