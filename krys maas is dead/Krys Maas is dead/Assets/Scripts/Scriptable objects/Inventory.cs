using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Inventory : MonoBehaviour
{
    #region Singleton
    public static Inventory instance;

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
    public int space = 20;

    public delegate void onItemChanged();
    public onItemChanged onItemChangedCallback;

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
            if(onItemChangedCallback != null)
            {
                onItemChangedCallback.Invoke();
            }
            
        }
        return true;
    }

    public void remove(Item item)
    {
        items.Remove(item);
        if (onItemChangedCallback != null)
        {
            onItemChangedCallback.Invoke();
        }
    }
}
