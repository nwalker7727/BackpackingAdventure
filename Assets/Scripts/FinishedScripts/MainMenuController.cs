using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject optionsMenu;
    // Start is called before the first frame update
   
    public void Start(){
        GameObject inv = GameObject.FindWithTag("inventory");
        if(inv != null){
            Destroy(inv);
        }
    }
    public void playGame(){
        SceneManager.LoadScene("Day1-P");
    }
    public void options(){
        mainMenu.SetActive(false);
        optionsMenu.SetActive(true);
    }
    public void back(){
        mainMenu.SetActive(true);
        optionsMenu.SetActive(false);
    }
    public void credits(){
        SceneManager.LoadScene("Credits");
    }
    public void levelBack(){
        SceneManager.LoadScene("Main Menu");
    }
}
