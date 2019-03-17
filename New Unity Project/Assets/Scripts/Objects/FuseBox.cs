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

    [SerializeField]
    private GameObject Lift, Door1, Door2;
    private open_close oc,oc1,oc2;



    private SpriteRenderer sr;
    void Start()
    {
        sr = gameObject.GetComponent<SpriteRenderer>();
        if (Lift)
        {
            oc = Lift.GetComponent<open_close>();
        }
        if (Door1)
        {
            oc1 = Door1.GetComponent<open_close>();
            oc2 = Door2.GetComponent<open_close>();
        }
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
            if (Lift)
            {
                oc.Open();
            }
            if (Door1)
            {
                oc1.Open();
                oc2.Open();
                Door1.SendMessage("Open");
                Door2.SendMessage("Open");
            }
        }
    }

    public void setFuses(int f)
    {
        fuses = f;
    }
}
