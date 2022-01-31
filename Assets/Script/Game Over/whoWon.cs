using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// Do not need another script now but I had this connect to a 4th scene

public class whoWon : MonoBehaviour
{
    public static int winnerWW = 0;

    private bool done;

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        if (hpbarP1.player1HP == 0)
        {
            //Player1hp = 0 means player 2 won
            // Debug.Log("player2 won");
            winnerWW = 1;  
        }
        else if (hpbarP2.player2HP == 0)
        {
            // Player2Hp hitting zero means player 1 won
            // Debug.Log("player1 won");
            winnerWW = 2;
        }
    }
}
