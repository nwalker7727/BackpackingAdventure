using UnityEngine;
using UnityEngine.UI;

public class ToggleCanvas : MonoBehaviour
{
    public GameObject objectToDisable;
    public GameObject objectToEnable;

    private void Start()
    {
        // Ensure both objects are initially in the desired state
        if (objectToDisable != null)
            objectToDisable.SetActive(true);
        if (objectToEnable != null)
            objectToEnable.SetActive(false);
    }

    public void OnButtonClick()
    {
        // Check if objects are assigned
        if (objectToDisable == null || objectToEnable == null)
        {
            Debug.LogWarning("Objects not assigned in the inspector!");
            return;
        }

        // Disable one object and enable the other
        objectToDisable.SetActive(false);
        objectToEnable.SetActive(true);
    }
}

