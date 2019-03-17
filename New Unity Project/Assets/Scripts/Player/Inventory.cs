using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    // Start is called before the first frame update

    public List<string> tags;
    public List<KeyInventoryInfo> keys;
    public AxeInventoryInfo axe = null;
    public TorchInventoryInfo torch = null;
    public LighterInventoryInfo lighter = null;
    public int fuses = 0;

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

    public void addAxe(AxeInventoryInfo a)
    {
        axe = a;
    }

    public void addTorch(TorchInventoryInfo t)
    {
        torch = t;
    }

    public void addLighter(LighterInventoryInfo l)
    {
        lighter = l;
    }
}
