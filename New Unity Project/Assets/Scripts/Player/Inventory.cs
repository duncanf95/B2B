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
        AxeIcon = GameObject.Find("AxeIcon");
        BlueKeyIcon = GameObject.Find("BlueKeyIcon").GetComponent<GameObject>();
        RedKeyIcon = GameObject.Find("RedKeyIcon").GetComponent<GameObject>();
        YellowKeyIcon = GameObject.Find("YellowKeyIcon").GetComponent<GameObject>();
        GreenKeyIcon = GameObject.Find("GreenKeyIcon").GetComponent<GameObject>();
        LighterIcon = GameObject.Find("LighterIcon").GetComponent<GameObject>();
        TorchIcon = GameObject.Find("TorchIcon").GetComponent<GameObject>();
        Lift1Icon = GameObject.Find("Lift1Icon").GetComponent<GameObject>();
        Lift2Icon = GameObject.Find("Lift2Icon").GetComponent<GameObject>();
        Lift3Icon = GameObject.Find("Lift3Icon").GetComponent<GameObject>();
        Fuse1Icon = GameObject.Find("Fuse1Icon").GetComponent<GameObject>();
        Fuse2Icon = GameObject.Find("Fuse2Icon").GetComponent<GameObject>();
        Fuse3Icon = GameObject.Find("Fuse3Icon").GetComponent<GameObject>();
        SyringeIcon = GameObject.Find("SyringeIcon").GetComponent<GameObject>();
        Code1Icon = GameObject.Find("Code1Icon").GetComponent<GameObject>();
        Code2Icon = GameObject.Find("Code2Icon").GetComponent<GameObject>();
        Code3Icon = GameObject.Find("Code3Icon").GetComponent<GameObject>();
        Collectible1Icon = GameObject.Find("Collectible1Icon").GetComponent<GameObject>();
        Collectible2Icon = GameObject.Find("Collectible2Icon").GetComponent<GameObject>();
        Collectible3Icon = GameObject.Find("Collectible3Icon").GetComponent<GameObject>();
        Collectible4Icon = GameObject.Find("Collectible4Icon").GetComponent<GameObject>();
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
    }

    public void addLighter(LighterInventoryInfo l)
    {
        lighter = l;
    }

    public void addSyringe(SyringeInventoryInfo s)
    {
        syringe = s;
    }
}
