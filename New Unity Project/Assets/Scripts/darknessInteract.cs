using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class darknessInteract : MonoBehaviour
{
    private bool triggered = false;
    private Inventory inv;
    [SerializeField]
    private float darkTime;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (triggered)
        {
            if (Input.GetButtonDown("Interact"))
            {
                if (inv.torch.selected)
                {
                    gameObject.GetComponent<SpriteRenderer>().sortingLayerName = "Default";
                    StartCoroutine(DarkTimer());
                }
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            inv = collision.gameObject.GetComponent<Inventory>();
            triggered = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            triggered = false;
        }
    }

    
   private IEnumerator DarkTimer()
   {
        Debug.Log("in coroutine");
        yield return new WaitForSeconds(darkTime);
        gameObject.GetComponent<SpriteRenderer>().sortingLayerName = "EnemyFront";
    }
    
}
