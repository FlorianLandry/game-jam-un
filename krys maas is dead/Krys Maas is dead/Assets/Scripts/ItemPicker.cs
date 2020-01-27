using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPicker : Interactable
{

    public override void interact()
    {
        pickUp();
    }

    void pickUp()
    {
        pc.focus = null;
        Destroy(gameObject);
        
    }
}
