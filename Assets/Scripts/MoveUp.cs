using UnityEngine;

public class MoveUp : MonoBehaviour
{
    public float speed = 5.0f; // Speed set in the inspector
    void Start()
    {
        Invoke("StartMoving", 2.0f); // Wait for 2 seconds before calling StartMoving
    }

    void StartMoving()
    {
        InvokeRepeating("MoveUpwards", 0.0f, 0.02f); // Start moving upwards
    }

    void MoveUpwards()
    {
        transform.Translate(Vector3.up * speed * Time.deltaTime); // Move the object upward
    }
}