using UnityEngine;

public class HatsUI : MonoBehaviour
{
    public Transform hatsParent;
    HatInventory inventory;
    HatsSlot[] hatSlots;

    // Start is called before the first frame update
    void Start()
    {
        inventory = HatInventory.instance;
        inventory.onHatChangedCallback += updateUI;
        hatSlots = hatsParent.GetComponentsInChildren<HatsSlot>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void updateUI()
    {
        for (int i = 0; i < hatSlots.Length; i++)
        {
            if(i < inventory.items.Count)
            {
                
            }
        }
    }
}
