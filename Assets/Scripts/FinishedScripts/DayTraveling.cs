using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class DayTraveling : MonoBehaviour
{
    // Start is called before the first frame update

    // Update is called once per frame
    public string nextScene;
    public void travel(){
        SceneManager.LoadScene(nextScene);
    }
}
