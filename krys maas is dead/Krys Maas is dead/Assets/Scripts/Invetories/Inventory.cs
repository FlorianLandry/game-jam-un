using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Inventory : MonoBehaviour
{
    public delegate void onHatChanged(Item item);
    public onHatChanged onHatChangedCallback;
    public delegate void onJacketChanged();
    public onJacketChanged onJacketChangedCallback;
    public delegate void onPantsChanged();
    public onPantsChanged onPantsChangedCallback;
    public static Inventory instance;
    #region Singleton


    private void Awake()
    {
        if(instance != null)
        {
            Debug.LogWarning("More than one instance of inventory found !!!!!");
            return;
        }
        instance = this;
        instance.onHatChangedCallback += GameObject.Find("Canvas").GetComponent<HatsUI>().addToHatInventory;
        instance.onHatChangedCallback += GameObject.Find("Canvas").GetComponent<HatsUI>().updateUI;
    }

    #endregion

    
    public List<Item> items = new List<Item>();
    public int space = 4;

    

    public bool add(Item item)
    {
        if (!item.isDefaultItem)
        {   
            if(items.Count >= space)
            {
                Debug.Log("Not enough space");
                return false;
            }
            if(item.type == "hat")
            {
                if (onHatChangedCallback != null)
                {
                    onHatChangedCallback.Invoke(item);
                }
            } else if(item.type == "pants")
            {
                Debug.Log(item.name);
            }
            else
            {
                Debug.Log(item.name);
            }

            
        }
        return true;
    }

    public void remove(Item item)
    {
        items.Remove(item);
        if (item.type == "pants")
        {

        }
        else if (item.type == "hat")
        {
            if (onHatChangedCallback != null)
            {
                onHatChangedCallback.Invoke(item);
            }
        }
        else
        {

        }
        
    }
}
