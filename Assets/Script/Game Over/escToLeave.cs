using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Escape to quit the application

public class escToLeave : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            // Debug.Log("leave");
            Application.Quit();
        }
    }
}
