using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelSkip : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F1))
        {
            Application.LoadLevel("Level 1");
        }

        if (Input.GetKeyDown(KeyCode.F2))
        {
            Application.LoadLevel("Level 2");
        }

        if (Input.GetKeyDown(KeyCode.F3))
        {
            Application.LoadLevel("Level 3");
        }

        if (Input.GetKeyDown(KeyCode.F4))
        {
            Application.LoadLevel("Level 4");
        }
    }
}
