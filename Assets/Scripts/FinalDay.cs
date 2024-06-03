using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinalDay : MonoBehaviour
{
    public GameObject traveler;
    public GameObject sol1;
    public GameObject sol2;
    public GameObject sol1fail;
    public GameObject sol2fail;
    public GameObject mudBack;
    public GameObject failText;
    public GameObject sol1B;
    public GameObject sol2B;
    private int failcount = 0;
    // Start is called before the first frame update
    public void solution(){
        if(gameObject == sol1 && InventoryCount.Instance.Get("rope") > 0){
            InventoryCount.Instance.Modify("rope", -1);
            sol1.SetActive(false);
            sol2.SetActive(false);
            sol1B.SetActive(false);
            sol2B.SetActive(false);
            traveler.SetActive(true);
            mudBack.SetActive(false);
        }
        else if(gameObject == sol1 && InventoryCount.Instance.Get("rope") == 0){
            //InventoryCount.Instance.Modify("rope", -1);
            sol1.SetActive(false);
            sol1fail.SetActive(true);
            Debug.Log(sol1fail.activeSelf);
            if(sol1fail.activeSelf && sol2fail.activeSelf){
                failText.SetActive(true);
                Invoke("failed", 5f);
            }
        }
        if(gameObject == sol2 && InventoryCount.Instance.Get("sticks") >= 5 && InventoryCount.Instance.Get("sap") >= 1){
            InventoryCount.Instance.Modify("sticks", -5);
            InventoryCount.Instance.Modify("sap", -1);
            sol1.SetActive(false);
            sol2.SetActive(false);
            sol1B.SetActive(false);
            sol2B.SetActive(false);
            traveler.SetActive(true);
            mudBack.SetActive(false);
        }
        else if(gameObject == sol2 && (InventoryCount.Instance.Get("sticks") < 5 || InventoryCount.Instance.Get("sap") == 0)){
            sol2.SetActive(false);
            sol2fail.SetActive(true);
            Debug.Log(sol1fail.activeSelf);
            if(sol1fail.activeSelf && sol2fail.activeSelf){
                failText.SetActive(true);
                Invoke("failed", 5f);
            }
        }
    }
    void failed(){
        SceneManager.LoadScene("Main Menu");
    }
}
