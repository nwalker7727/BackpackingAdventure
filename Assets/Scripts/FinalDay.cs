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
    public GameObject win;
    public GameObject fail;
    // Start is called before the first frame update
    public void solution(){
        if(SceneManager.GetActiveScene().name == "Day1-F"){
            if(gameObject == sol1 && InventoryCount.Instance.Get("rope") > 0){
                InventoryCount.Instance.Modify("rope", -1);
                sol1.SetActive(false);
                sol2.SetActive(false);
                sol1B.SetActive(false);
                sol2B.SetActive(false);
                traveler.SetActive(true);
                mudBack.SetActive(false);
                win.SetActive(true);
            }
            else if(gameObject == sol1 && InventoryCount.Instance.Get("rope") == 0){
                //InventoryCount.Instance.Modify("rope", -1);
                sol1.SetActive(false);
                sol1fail.SetActive(true);
                Debug.Log(sol1fail.activeSelf);
                if(sol1fail.activeSelf && sol2fail.activeSelf){
                    fail.SetActive(true);
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
                win.SetActive(true);
            }
            else if(gameObject == sol2 && (InventoryCount.Instance.Get("sticks") < 5 || InventoryCount.Instance.Get("sap") == 0)){
                sol2.SetActive(false);
                sol2fail.SetActive(true);
                Debug.Log(sol1fail.activeSelf);
                if(sol1fail.activeSelf && sol2fail.activeSelf){
                    fail.SetActive(true);
                    failText.SetActive(true);
                    Invoke("failed", 5f);
                }
            }
        }
        if(SceneManager.GetActiveScene().name == "Day2-F"){
            if(gameObject == sol1 && InventoryCount.Instance.Get("rope") > 0 && InventoryCount.Instance.Get("tarp") > 0 && InventoryCount.Instance.Get("sticks") > 0){
                InventoryCount.Instance.Modify("rope", -1);
                sol1.SetActive(false);
                sol2.SetActive(false);
                sol1B.SetActive(false);
                sol2B.SetActive(false);
                traveler.SetActive(true);
                mudBack.SetActive(false);
                win.SetActive(true);
            }
            else if(gameObject == sol1 && (InventoryCount.Instance.Get("rope") == 0 || InventoryCount.Instance.Get("tarp") == 0 && InventoryCount.Instance.Get("sticks") == 0)){
                //InventoryCount.Instance.Modify("rope", -1);
                sol1.SetActive(false);
                sol1fail.SetActive(true);
                Debug.Log(sol1fail.activeSelf);
                if(sol1fail.activeSelf && sol2fail.activeSelf){
                    fail.SetActive(true);
                    failText.SetActive(true);
                    Invoke("failed", 3f);
                }
            }
            if(gameObject == sol2 && InventoryCount.Instance.Get("rocks") >= 3 && InventoryCount.Instance.Get("ductTape") >= 1 && InventoryCount.Instance.Get("sticks") >= 1){
                InventoryCount.Instance.Modify("mFlower", -1);
                InventoryCount.Instance.Modify("rocks", -3);
                InventoryCount.Instance.Modify("sticks", -1);
                sol1.SetActive(false);
                sol2.SetActive(false);
                sol1B.SetActive(false);
                sol2B.SetActive(false);
                traveler.SetActive(true);
                mudBack.SetActive(false);
                win.SetActive(true);
            }
            else if(gameObject == sol2 && (InventoryCount.Instance.Get("sticks") == 0 || InventoryCount.Instance.Get("ductTape") == 0 || InventoryCount.Instance.Get("rocks") < 3)){
                sol2.SetActive(false);
                sol2fail.SetActive(true);
                Debug.Log(sol1fail.activeSelf);
                if(sol1fail.activeSelf && sol2fail.activeSelf){
                    fail.SetActive(true);
                    failText.SetActive(true);
                    Invoke("failed", 3f);
                }
            }
        }
        if(SceneManager.GetActiveScene().name == "Day3-F"){
            if(gameObject == sol1 && InventoryCount.Instance.Get("mFlower") >= 2 && InventoryCount.Instance.Get("berries") >= 2){
                InventoryCount.Instance.Modify("mFlower", -2);
                InventoryCount.Instance.Modify("berries", -2);
                sol1.SetActive(false);
                sol1B.SetActive(false);
                traveler.SetActive(true);
                win.SetActive(true);
            }
            else if(gameObject == sol1 && (InventoryCount.Instance.Get("berries") < 2 || InventoryCount.Instance.Get("mFlower") < 2)){
                sol1.SetActive(false);
                sol1fail.SetActive(true);
                Debug.Log(sol1fail.activeSelf);
                if(sol1fail.activeSelf){
                    fail.SetActive(true);
                    failText.SetActive(true);
                    Invoke("failed", 5f);
                }
            }
        }
    }
    void failed(){
        SceneManager.LoadScene("Main Menu");
    }
}
