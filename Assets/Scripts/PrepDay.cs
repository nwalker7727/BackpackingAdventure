using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrepDay : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject rope;
    public GameObject tarp;
    public GameObject ductTape;
    public void choose(){
        if(gameObject == rope){
            rope.SetActive(false);
            tarp.SetActive(false);
            ductTape.SetActive(false);
            InventoryCount.Instance.Modify("rope", 1);
        }
        if(gameObject == tarp){
            rope.SetActive(false);
            tarp.SetActive(false);
            ductTape.SetActive(false);
            InventoryCount.Instance.Modify("tarp", 1);
        }
        if(gameObject == ductTape){
            rope.SetActive(false);
            tarp.SetActive(false);
            ductTape.SetActive(false);
            InventoryCount.Instance.Modify("ductTape", 1);
        }

    }
}
