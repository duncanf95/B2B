using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteract : MonoBehaviour {

    // Use this for initialization

    private GameObject co = null;
	private string tag = null;

    private void Update()
    {
        if (Input.GetButtonDown("Interact"))
        {
            Debug.Log("button");
        }
        if (Input.GetButtonDown("Interact") && co && tag == "Door")
        {
            co.SendMessage("Open");
            gameObject.GetComponent<Inventory>().test = 12;
        }

        if (Input.GetButtonDown("Interact") && co && tag == "Metal Door")
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

        if (Input.GetButtonDown("Interact") && co && tag == "Lift")
        {
            Debug.Log("at metal door");

            foreach (KeyInventoryInfo key in gameObject.GetComponent<Inventory>().keys)
            {
                if (checkKey(co.GetComponent<LiftInteraction>().identifier, key.door))
                {
                    co.SendMessage("Open");
                    co.GetComponent<LiftInteraction>().open = true;
                }


            }
        }

        if (Input.GetButtonDown("Interact") && co && tag == "Key")
        {
            gameObject.GetComponent<Inventory>().addKey(
                co.GetComponent<KeyInventoryInfo>());
            co.SendMessage("PickUp");

        }
        if (Input.GetButtonDown("Interact") && co && tag == "AxeItem")
        {
            gameObject.GetComponent<Inventory>().addAxe(
                co.GetComponent<AxeInventoryInfo>());
            co.SendMessage("PickUp");

        }
        if (Input.GetButtonDown("Interact") && co && tag == "Torch")
        {
            gameObject.GetComponent<Inventory>().addTorch(
                co.GetComponent<TorchInventoryInfo>());
            co.SendMessage("PickUp");

        }

        if (Input.GetButtonDown("Interact") && co && tag == "Lighter")
        {
            gameObject.GetComponent<Inventory>().addLighter(
                co.GetComponent<LighterInventoryInfo>());
            co.SendMessage("PickUp");

        }

        if (Input.GetButtonDown("Interact") && co && tag == "Fire")
        {
            if (gameObject.GetComponent<Inventory>().lighter)
            {
                if (gameObject.GetComponent<Inventory>().lighter.selected)
                {
                    co.SendMessage("LightFire");
                }

            }
        }
        if (Input.GetButtonDown("Interact") && co && tag == "HP")
        {
            co.SendMessage("PickUp");
            Player p = gameObject.GetComponent<Player>();
            p.increaseHealth(50);
        }

        if (Input.GetButtonDown("Interact") && co && tag == "Fuse")
        {
            co.SendMessage("PickUp");
            gameObject.GetComponent<Inventory>().fuses++;
        }

        if (Input.GetButtonDown("Interact") && co && tag == "FuseBox")
        {
            int fuses = gameObject.GetComponent<Inventory>().fuses;
            co.SendMessage("PickUp");
            co.GetComponent<FuseBox>().setFuses(fuses);
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

        if (collision.CompareTag("Lift"))
        {
            co = collision.gameObject;
            tag = "Lift";
        }

        if (collision.CompareTag("Axe"))
        {
            co = collision.gameObject;
            tag = "Axe";
        }

        if (collision.CompareTag("AxeItem"))
        {
            co = collision.gameObject;
            tag = "AxeItem";
        }

        if (collision.CompareTag("Torch"))
        {
            co = collision.gameObject;
            tag = "Torch";
        }

        if (collision.CompareTag("Lighter"))
        {
            co = collision.gameObject;
            tag = "Lighter";
        }

        if (collision.CompareTag("Fire"))
        {
            co = collision.gameObject;
            tag = "Fire";
        }

        if (collision.CompareTag("HP"))
        {
            co = collision.gameObject;
            tag = "HP";
        }

        if (collision.CompareTag("Fuse"))
        {
            co = collision.gameObject;
            tag = "Fuse";
        }

        if (collision.CompareTag("FuseBox"))
        {
            co = collision.gameObject;
            tag = "FuseBox";
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

        co = null;
        tag = null;
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
