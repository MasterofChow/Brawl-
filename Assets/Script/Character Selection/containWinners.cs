using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This class is necessary for the trophy count because it holds player 1 and player 2 wins

public class containWinners : MonoBehaviour
{
    public static int player1Wins = 0;
    public static int player2Wins = 0;
    // Start is called before the first frame update
    void Start()
    {
        // Normally once the players enter a new stage all objects get destroyed and reset if the scene enters again
        // I need to mantain the scores for storage and make sure the amount of wins do not change
        DontDestroyOnLoad(this.gameObject);
    }
}
