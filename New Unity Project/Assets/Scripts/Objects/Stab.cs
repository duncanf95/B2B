using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stab : MonoBehaviour
{
    // Start is called before the first frame update
    private string tag;
    private GameObject g = null;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(tag == "Enemy" && g && Input.GetButtonDown("Interact"))
        {
            g.SendMessage("sleep");
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
}
