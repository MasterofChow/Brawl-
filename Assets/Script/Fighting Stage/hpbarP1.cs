using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hpbarP1 : MonoBehaviour
{
    public static float player1HP;
    public static Vector3 barPosition1;
    Vector3 temp1;
    public static bool playDeathAnim1;
    public static bool addOne;
    void Awake()
    {
        addOne = true;

        playDeathAnim1 = false;

        player1HP = 100;

        barPosition1 = transform.position;
        
        temp1 = transform.localScale;
        temp1 = new Vector3 (.36375f, .8f, 1f);
        transform.localScale = temp1;
    }

    // Update is called once per frame
    void Update()
    {
        if (player1HP >= 0)
        {
            transform.position = barPosition1;
            temp1.x = player1HP/125;
            transform.localScale = temp1;
        }
            
        if (player1HP <= 0 && addOne == true)
        {
            // Debug.Log("Game Over");
            // Debug.Log("Player 2 Wins");
            containWinners.player2Wins = containWinners.player2Wins + 1;
            addOne = false;
            // Application.LoadLevel("Game Over");
        }
    }

    IEnumerator waitASec()
    {
        yield return new WaitForSeconds(.2f);
        startGame.freezeMovementNotYet = false;
    }
}
