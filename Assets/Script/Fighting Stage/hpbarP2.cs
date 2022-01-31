using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hpbarP2 : MonoBehaviour
{
    public static float player2HP;
    public static Vector3 barPosition2;
    Vector3 temp2;
    public static bool playDeathAnim2;
    public static bool addOne;
    void Awake()
    {
        addOne = true;

        playDeathAnim2 = false;

        player2HP = 100;
        
        barPosition2 = transform.position;

        temp2 = transform.localScale;
        temp2 = new Vector3 (.36375f, .8f, 1f);
        transform.localScale = temp2;
    }

    // Update is called once per frame
    void Update()
    {
        if (player2HP >= 0)
        {
            transform.position = barPosition2;
            temp2.x = player2HP/125;
            transform.localScale = temp2;
        }
        if (player2HP <= 0 && addOne == true)
        {
            // Debug.Log("Game Over");
            // Debug.Log("Player 1 Wins");
            containWinners.player1Wins = containWinners.player1Wins + 1;
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
