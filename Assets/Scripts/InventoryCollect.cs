using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryCollect : MonoBehaviour
{
    // Start is called before the first frame update
    // Update is called once per frame
    public void collection(){
        InventoryCount.sticks +=1;
        Debug.Log(InventoryCount.sticks);
        gameObject.SetActive(false);
    }
}
