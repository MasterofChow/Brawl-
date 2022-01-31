using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// Loops the circle of the game

public class enterStartScreen : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        // Debug.Log(whoWon.winnerWW);
        if (Input.GetKeyDown(KeyCode.Return))
        {
            hpbarP1.addOne = true;
            hpbarP2.addOne = true;
            whoWon.winnerWW = 0;
            continueBackgroundMusic.started = true;
            SceneManager.LoadScene("Ubrawl");
        }
    }
}
