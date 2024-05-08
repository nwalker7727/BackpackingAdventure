/*
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // Ensure you have this for Button and Text

public class InventoryVisualized : MonoBehaviour
{
    public GameObject backPack;
    public Button me;
    public string[] inventory; // Corrected the data type to lowercase 'string'
    public string[] varNames;
    public string itemName;
    private int i = 0;

    void Start()
    {
        inventory = new string[] { "Sticks", "Meadow Flowers" };
        varNames = new string[] {"sticks", "mFlower"}; // Initialize the array this way
    }

    void Update()
    {
        // You can add update logic here if needed
    }

    public void ChangeText()
    {   
        if (i < varNames.Length)
        {
            me.GetComponentInChildren<Text>().text = inventory[i] + ": " + InventoryCount.get(varNames[i]);
            i++; // Increment the index for the next iteration
        }
}

}


*/