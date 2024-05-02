using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalDay : MonoBehaviour
{
    public GameObject traveler;
    public GameObject sol1;
    public GameObject sol2;
    // Start is called before the first frame update
    public void solution(){
        if(gameObject == sol1 && InventoryCount.rope > 0){
            InventoryCount.rope -= 1;
            sol1.SetActive(false);
            sol2.SetActive(false);
            traveler.SetActive(true);
        }
        if(gameObject == sol2 && InventoryCount.sticks >= 8){
            InventoryCount.sticks -= 8;
            sol1.SetActive(false);
            sol2.SetActive(false);
            traveler.SetActive(true);
        }
    }
}
