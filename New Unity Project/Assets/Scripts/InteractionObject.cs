using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionObject : MonoBehaviour {

    [SerializeField]
    private Sprite OpenSprite, CloseSprite;

    [SerializeField]
    private float closeTime;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        closeTime -= Time.deltaTime;
        if(closeTime <= 0)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = CloseSprite;
            Close();
        }
	}

    void Open()
    {
        Debug.Log("Interacted open woo");

        GetComponent<Rigidbody2D>().simulated = false;

        gameObject.GetComponent<SpriteRenderer>().sprite = OpenSprite;
        closeTime = 3.0f;
        
    }
    void Close()
    {
        Debug.Log("Interacted close woo");

        GetComponent<Rigidbody2D>().simulated = true;
    }

}
