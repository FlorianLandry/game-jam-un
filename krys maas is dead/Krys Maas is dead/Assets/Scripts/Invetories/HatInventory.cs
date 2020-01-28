using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class HatInventory : Inventory
{
    public new static HatInventory instance;

    #region Singleton


    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("More than one instance of inventory found !!!!!");
            return;
        }
        instance = this;
    }

    #endregion
}
