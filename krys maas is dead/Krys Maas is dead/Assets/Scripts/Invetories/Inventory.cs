using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Inventory : MonoBehaviour
{
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
    }

    #endregion

    public List<Item> items = new List<Item>();
    public int space = 4;

    public delegate void onHatChanged();
    public onHatChanged onHatChangedCallback;
    public delegate void onJacketChanged();
    public onJacketChanged onJacketChangedCallback;
    public delegate void onPantsChanged();
    public onPantsChanged onPantsChangedCallback;

    public bool add(Item item)
    {
        if (!item.isDefaultItem)
        {   
            if(items.Count >= space)
            {
                Debug.Log("Not enough space");
                return false;
            }
            items.Add(item);
            if(item.type == "pants")
            {
                
            } else if(item.type == "hat")
            {
                if (onHatChangedCallback != null)
                {
                    onHatChangedCallback.Invoke();
                }
            }
            else
            {

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
                onHatChangedCallback.Invoke();
            }
        }
        else
        {

        }
        
    }
}
