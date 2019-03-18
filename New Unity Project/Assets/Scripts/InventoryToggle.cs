using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryToggle : MonoBehaviour
{
    public static bool InventoryisOpen = false;

    public GameObject Inv;

    private void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            if (InventoryisOpen == false)
            {
                InventoryisOpen = true;
                Inv.SetActive(true);
            }

            else
            {
                InventoryisOpen = false;
                Inv.SetActive(false);  
            }               
        }
    }  

}
