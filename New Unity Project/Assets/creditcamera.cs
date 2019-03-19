using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class creditcamera : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 d = Vector2.zero;
        d += Vector2.down;
        transform.Translate(d * 1.0f * Time.deltaTime);
        if(transform.position.y <= -50)
        {
            Application.LoadLevel("TitleScreen");
        }
    }
}
