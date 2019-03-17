using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxeFollow : MonoBehaviour
{
    // Start is called before the first frame update
    private Transform target;
    void Start()
    {
        target = GameObject.Find("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (Math.Truncate(gameObject.transform.rotation.eulerAngles.z) == 315)
        {
            transform.position = new Vector3(target.position.x + 0.35f,
                                                            target.position.y + 0.2f,
                                                            transform.position.z);
        }
 
        if (Math.Truncate(gameObject.transform.rotation.eulerAngles.z) == 224)
        {
            transform.position = new Vector3(target.position.x + 0.35f,
                                                            target.position.y - 0.35f,
                                                            transform.position.z);
        }

        if (Math.Truncate(gameObject.transform.rotation.eulerAngles.z) == 135)
        {
            transform.position = new Vector3(target.position.x - 0.35f,
                                                            target.position.y - 0.2f,
                                                            transform.position.z);
        }

        if (Math.Truncate(gameObject.transform.rotation.eulerAngles.z) == 45)
        {
            transform.position = new Vector3(target.position.x - 0.35f,
                                                            target.position.y + 0.2f,
                                                            transform.position.z);
        }

        if (Math.Truncate(gameObject.transform.rotation.eulerAngles.z) == 0)
        {
            transform.position = new Vector3(target.position.x,
                                                            target.position.y + 0.2f,
                                                            transform.position.z);
        }

        if (Math.Truncate(gameObject.transform.rotation.eulerAngles.z) == 270)
        {
            transform.position = new Vector3(target.position.x + 0.35f,
                                                            target.position.y,
                                                            transform.position.z);
        }

        if (Math.Truncate(gameObject.transform.rotation.eulerAngles.z) == 180)
        {
            transform.position = new Vector3(target.position.x,
                                                            target.position.y - 0.35f,
                                                            transform.position.z);
        }

        if (Math.Truncate(gameObject.transform.rotation.eulerAngles.z) == 90)
        {
            transform.position = new Vector3(target.position.x - 0.35f,
                                                            target.position.y,
                                                            transform.position.z);
        }

        if (target.GetComponent<Inventory>().axe)
        {
            if (target.GetComponent<Inventory>().axe.selected == true)
            {
                //target.GetComponent<Inventory>().axe.gameObject.GetComponent<SpriteRenderer>().sortingLayerName = "Default";
            }

        }
    }
}
