﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    // Start is called before the first frame update

    public List<string> tags;
    public List<KeyInventoryInfo> keys;
    public int test;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void addKey(KeyInventoryInfo key)
    {
        Debug.Log(key.identifier);
        keys.Add(key);
    }
}