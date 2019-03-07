using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    // Start is called before the first frame update

    public List<string> tags;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void addKey()
    {
        tags.Add("key");
    }
}
