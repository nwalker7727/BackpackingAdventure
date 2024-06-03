using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryCount : MonoBehaviour
{
    // Singleton instance
    private static InventoryCount _instance;
    public static InventoryCount Instance { get { return _instance; } }

    // Inventory dictionary
    public Dictionary<string, int> inventory = new Dictionary<string, int>{
        {"rope", 0},
        {"ductTape", 0},
        {"knife", 0},
        {"sticks", 0},
        {"sap", 0},
        {"mFlower", 0},
        {"rocks", 0},
        {"berries", 0}
    };

    private void Awake()
    {
        // Singleton pattern implementation
        if (_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            _instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
    }

    public int Get(string itemName)
    {
        if (inventory.ContainsKey(itemName))
        {
            return inventory[itemName];
        }
        else
        {
            Debug.LogError("Item count not found for: " + itemName);
            return 0; // Return 0 if item count is not found
        }
    }

    public void Modify(string itemName, int value)
    {
        if (inventory.ContainsKey(itemName))
        {
            inventory[itemName] += value;
        }
        else
        {
            Debug.LogError("Item count not found for: " + itemName);
        }
    }
}
