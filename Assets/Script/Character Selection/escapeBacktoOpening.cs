using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// Class goes back to the Intro Scene from the Character Select Scene

public class escapeBacktoOpening : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            // Debug.Log("should go back");
            SceneManager.LoadScene("Ubrawl");
        }
    }
}
