using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuseBox : MonoBehaviour
{
    // Start is called before the first frame update
    public int fuses;
    [SerializeField]
    private Sprite f1;
    [SerializeField]
    private Sprite f2;
    [SerializeField]
    private Sprite f3;

    private SpriteRenderer sr;
    void Start()
    {
        sr = gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        checkState();
    }

    private void checkState()
    {
        if(fuses == 1)
        {
            sr.sprite = f1;
        }

        if (fuses == 2)
        {
            sr.sprite = f2;
        }

        if (fuses == 3)
        {
            sr.sprite = f3;
        }
    }

    public void setFuses(int f)
    {
        fuses = f;
    }
}
