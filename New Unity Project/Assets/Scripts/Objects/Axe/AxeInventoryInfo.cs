using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxeInventoryInfo : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private float Damage;
    [SerializeField]
    private string identifier;
    [SerializeField]
    public bool selected;

    private Sprite sprite;
    void Start()
    {
        sprite = gameObject.GetComponent<Sprite>();
        if(sprite = null)
        {
            Debug.Log("sprite null");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
