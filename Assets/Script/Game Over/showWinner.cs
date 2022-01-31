using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// When a brawler wins then the player who wins will show on the scene

public class showWinner : MonoBehaviour
{
    public GameObject player1Sheet;
    public GameObject player2Sheet;
    public GameObject escToLeave;
    public GameObject entToPlayAgain;
    public bool audioOnce;
    private AudioSource source;
    public static AudioClip player1Wins;
    public static AudioClip player2Wins;
    // Start is called before the first frame update
    void Awake()
    {
        whoWon.winnerWW = 0;
        audioOnce = false;
        player1Sheet.SetActive(false);
        player2Sheet.SetActive(false);
        escToLeave.SetActive(false);
        entToPlayAgain.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        if (playDeathAnimation.animationPlayed == true)
        {
            // Show player 1 wins the text
            if (whoWon.winnerWW == 2)
            {
                // Debug.Log("showPlayer1");
                player1Sheet.SetActive(true);
                escToLeave.SetActive(true);
                entToPlayAgain.SetActive(true);
            }
            // Show player 2 wins the text
            else if (whoWon.winnerWW == 1)
            {
                // Debug.Log("player2show");
                player2Sheet.SetActive(true);
                escToLeave.SetActive(true);
                entToPlayAgain.SetActive(true);
            }
        }
    }
}
