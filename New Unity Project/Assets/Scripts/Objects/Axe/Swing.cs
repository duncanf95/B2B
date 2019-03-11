using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swing : MonoBehaviour
{

    public Rigidbody2D enemy;
    public bool triggered;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (triggered)
        {
            if (Input.GetButton("Fire2"))
            {
                if (enemy != null)
                {
                    gameObject.GetComponent<KnockBack>().enemyknockback(enemy);
                    Debug.Log("Swing");
                }
            }
        }
    }


}
