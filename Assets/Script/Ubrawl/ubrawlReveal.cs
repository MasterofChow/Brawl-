// Type writer affect YouTube Video:
// https://www.youtube.com/watch?v=1qbjmb_1hV4&feature=emb_logo

using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

// The class is attached the the text mesh at the opening screen
// It allows each letter of the text to show up one after the other and not all at the same time

public class ubrawlReveal : MonoBehaviour
{
    public float delay = 0.1f;
    public string fullText;
    private string currentText = "";

    public static bool doneWithText = false;
    void Start()
    {
        StartCoroutine(ShowText());
    }

    IEnumerator ShowText()
    {
        // Prints each letter
        for (int i = 0; i <= fullText.Length; i++)
        {
            // Debug.Log(currentText);
            currentText = fullText.Substring(0,i);
            gameObject.GetComponent<TextMeshPro>().text = currentText;
            yield return new WaitForSeconds (delay);
        }
        doneWithText = true;
    }
}
