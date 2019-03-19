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
    public SyringeInventoryInfo syringe = null;
    public int fuses = 0;
    public GameObject AxeIcon;
    public GameObject BlueKeyIcon;
    public GameObject RedKeyIcon;
    public GameObject YellowKeyIcon;
    public GameObject GreenKeyIcon;
    public GameObject LighterIcon;
    public GameObject TorchIcon;
    public GameObject Lift1Icon;
    public GameObject Lift2Icon;
    public GameObject Lift3Icon;
    public GameObject Fuse1Icon;
    public GameObject Fuse2Icon;
    public GameObject Fuse3Icon;
    public GameObject SyringeIcon;
    public GameObject Code1Icon;
    public GameObject Code2Icon;
    public GameObject Code3Icon;
    public GameObject Collectible1Icon;
    public GameObject Collectible2Icon;
    public GameObject Collectible3Icon;
    public GameObject Collectible4Icon;

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
        AxeIcon.SetActive(true);
    }

    public void addTorch(TorchInventoryInfo t)
    {
        torch = t;
        TorchIcon.SetActive(true);
    }

    public void addLighter(LighterInventoryInfo l)
    {
        lighter = l;
        LighterIcon.SetActive(true);
    }

    public void addSyringe(SyringeInventoryInfo s)
    {
        syringe = s;
        SyringeIcon.SetActive(true);
    }

}
