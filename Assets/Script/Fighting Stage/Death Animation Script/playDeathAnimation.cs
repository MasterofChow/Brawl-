using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Play the death animation

public class playDeathAnimation : MonoBehaviour
{
    public static bool sendToAnotherScripttoPlayAudioPlayer1;
    public static bool sendToAnotherScripttoPlayAudioPlayer2;
    public GameObject wallRight;
    public GameObject wallLeft;
    private GameObject opponent;
    public Animator anim;
    public static bool animationPlayed;
    private int choosePlay;
    public static bool playedOnce;

    void Awake()
    {
        // source.clip = p1Wins;
        playedOnce = false;
        anim.SetBool("playDeathAnim", false);
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.tag == "player1")
        {
            opponent = GameObject.FindGameObjectWithTag("player2");
        }
        else if (gameObject.tag == "player2")
        {
            opponent = GameObject.FindGameObjectWithTag("player1");
        }
            
        // Debug.Log("choosePlay: "+choosePlay);
        choosePlay = whoWon.winnerWW;
        // Player 2 wins so player 1 death anim
        if (choosePlay == 1 && gameObject.tag == "player1")
        {
            // Debug.Log("should have played: P2");
            anim.SetBool("isAttacking", false);
            anim.SetBool("projectile", false);
            anim.SetBool("idle", false);
            anim.SetBool("playDeathAnim", true);
            StartCoroutine(delayGameStart());
        }
        // Player 1 wins so Player 2 death anim
        else if (choosePlay == 2 && gameObject.tag == "player2")
        {
            // Debug.Log("should have played: P1");
            // Debug.Log("player2DeathAnimation");
            anim.SetBool("isAttacking", false);
            anim.SetBool("projectile", false);
            anim.SetBool("idle", false);
            anim.SetBool("playDeathAnim", true);
            StartCoroutine(delayGameStart());
        }
    }

    IEnumerator delayGameStart()
    {
        // Layer 10 is set as Turon and his death animation is different than the other brawlers
        // He runs off the screen awway from the opponent
        if (gameObject.layer == 10)
        {
            // Debug.Log("option1");
            wallRight.SetActive(false);
            wallLeft.SetActive(false);
            if (gameObject.transform.position.x < opponent.transform.position.x)
            {
                transform.Translate(Vector2.left * Time.fixedDeltaTime * 5f);
            }
            else
            {
                transform.Translate(Vector2.right * Time.fixedDeltaTime * 5f);
            }
            yield return new WaitForSeconds(.55f);
            startGame.gameStart = false;
            startGame.freezeMovementNotYet = true;
            if (playedOnce == false)
            {
                if (hpbarP1.player1HP == 0)
                {
                    sendToAnotherScripttoPlayAudioPlayer2 = true;
                }
                else if (hpbarP2.player2HP == 0)
                {
                    sendToAnotherScripttoPlayAudioPlayer1 = true;
                }
                // Debug.Log("AudioCheck");
            }
                // Debug.Log("Turon");
            animationPlayed = true;
        }
        else 
        {
            // Debug.Log("option2");
            yield return new WaitForSeconds(.55f);
            startGame.gameStart = false;
            startGame.freezeMovementNotYet = true;
            anim.SetBool("playDeathAnim", false);
            gameObject.SetActive(false);
            if (playedOnce == false)
            {
                if (hpbarP1.player1HP == 0)
                {
                    sendToAnotherScripttoPlayAudioPlayer2 = true;
                }
                else if (hpbarP2.player2HP == 0)
                {
                    sendToAnotherScripttoPlayAudioPlayer1 = true;
                }
                // Debug.Log("AudioCheck");
            }

            // Debug.Log("animation played");
            animationPlayed = true;
        }
    }
}
