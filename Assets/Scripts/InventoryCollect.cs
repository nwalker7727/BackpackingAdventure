using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryCollect : MonoBehaviour
{
    public GameObject me;
    // Start is called before the first frame update
    // Update is called once per frame
    public void stickCollection(){
        InventoryCount.Instance.Modify("sticks", 1);
        //Debug.Log(InventoryCount.sticks);
        this.gameObject.SetActive(false);
    }
    public void mFlowerCollection(){
        InventoryCount.Instance.Modify("mFlower", 1);
        //Debug.Log("mFlowers: " + InventoryCount.mFlower);
        this.gameObject.SetActive(false);
    }
}
