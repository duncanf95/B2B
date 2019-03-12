using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class rooftriger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<TilemapRenderer>().sortingLayerName = "Roof";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            gameObject.GetComponent<TilemapRenderer>().sortingLayerName = "Default";
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
   
        if (collision.CompareTag("Player"))
        {
            gameObject.GetComponent<TilemapRenderer>().sortingLayerName = "Roof";
        }
    }
}
