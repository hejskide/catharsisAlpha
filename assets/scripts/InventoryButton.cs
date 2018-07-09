using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryButton : MonoBehaviour {

    public GameObject inventory;

    public void buttonClick ()
    {
        if (inventory.gameObject.activeInHierarchy == true)
        {
            Close();
        }
        else
        {
            Open();
        }

    }
    public void Open()
    {
        inventory.SetActive(true);
    }

    public void Close()
    {
        inventory.SetActive(false);
    }


}
