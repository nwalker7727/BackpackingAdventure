using UnityEngine;

public class DisableObjectAfterTime : MonoBehaviour
{
    // Time in seconds before the object gets disabled
    public float disableTime = 10f;

    void Start()
    {
        // Invoke the method to disable the object after disableTime seconds
        Invoke("DisableGameObject", disableTime);
    }

    void DisableGameObject()
    {
        // Set the object to inactive
        gameObject.SetActive(false);
    }
}