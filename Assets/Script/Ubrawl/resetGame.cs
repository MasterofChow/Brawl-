using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Resets the game at the beginning of the Game and everytime it loops

public class resetGame : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        hpbarP1.addOne = true;
        hpbarP2.addOne = true;
        whoWon.winnerWW = 0;
        playDeathAnimation.playedOnce = false;
        playDeathAnimation.sendToAnotherScripttoPlayAudioPlayer1 = false;
        playDeathAnimation.sendToAnotherScripttoPlayAudioPlayer2 = false;
    }

    // Update is called once per frame
    void Update()
    {
        DontDestroyOnLoad(this.gameObject);
    }
}
