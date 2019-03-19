using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkplayer : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject player;
    public GameObject collectable;
    string tag;
    SpriteRenderer sr;
    bool itemActive = false;
    void Start()
    {
        sr = collectable.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        check();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            tag = "Player";
            player = collision.gameObject;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            tag = null;
            player = null;
        }
    }

    private void check()
    {
        if (itemActive && Input.anyKeyDown)
        {
            sr.sortingLayerName = "Default";
            itemActive = false;
        }
        if (tag == "Player" && player && Input.GetButtonDown("Interact"))
        {
            sr.sortingLayerName = "Collectable";
            itemActive = true;
        }

       
    }
}
