using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stab : MonoBehaviour
{
    // Start is called before the first frame update
    private string tag;
    private GameObject g = null;
    private GameObject player;
    private Inventory inventory;
    [SerializeField]
    private float SOutTime;
    void Start()
    {
        player = GameObject.Find("Player");
        inventory = player.GetComponent<Inventory>();
    }

    // Update is called once per frame
    void Update()
    {
        if (tag == "Enemy" && g && Input.GetButtonDown("Interact"))
        {
            if (inventory.syringe.selected)
            {
                g.SendMessage("sleep");
                gameObject.GetComponent<SpriteRenderer>().sortingLayerName = "Objects";
                StartCoroutine(outTimer());
            }
        }

        if (Input.GetButtonDown("Interact"))
        {
            if (inventory.syringe.selected)
            {
                gameObject.GetComponent<SpriteRenderer>().sortingLayerName = "Objects";
                StartCoroutine(outTimer());

            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            g = collision.gameObject;
            tag = "Enemy";
        }


    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            g = null;
            tag = null;
        }
    }

    private IEnumerator outTimer()
    {
        yield return new WaitForSeconds(SOutTime);
        Debug.Log("s corutine");
        gameObject.GetComponent<SpriteRenderer>().sortingLayerName = "Default";
    }
}
