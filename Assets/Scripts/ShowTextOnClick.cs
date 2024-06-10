using System.Collections;
using UnityEngine;
using TMPro;

public class ShowTextOnClick : MonoBehaviour
{
    public TMP_Text textToShow;

    public void OnButtonClick()
    {
        StartCoroutine(ShowAndHideText());
    }

    IEnumerator ShowAndHideText()
    {
        textToShow.gameObject.SetActive(true); // Show the text

        yield return new WaitForSeconds(0.5f); // Wait for 1 second

        textToShow.gameObject.SetActive(false); // Hide the text
    }
}