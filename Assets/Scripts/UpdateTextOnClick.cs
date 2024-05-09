using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UpdateTextOnClick : MonoBehaviour
{
    [System.Serializable]
    public class InventoryItem
    {
        public string itemName;
        public TMP_Text textObject;
    }

    public List<InventoryItem> inventoryItems;

    private void Start()
    {
        UpdateTextValues();
    }

    public void UpdateTextValues()
    {
        foreach (InventoryItem item in inventoryItems)
        {
            int itemCount = InventoryCount.Instance.Get(item.itemName);
            item.textObject.text = "x" + itemCount.ToString();
        }
    }
}
