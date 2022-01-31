using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hitDetection : MonoBehaviour
{
    public static bool DMGed;
    public GameObject bigBody;

    public GameObject attachedTo;

    private float bigBodyNumber;
    string theTag;

    public static float meleeHit = 0f;

    public static float projectileHit = 0f;

    // private bool alreadyHit = false;

    public static bool playAnimExplosion1;
    public static bool playAnimExplosion2;

    private string enemyTag;

    public static string enemyName;

    private void Start()
    {
        DMGed = false;
        bigBodyNumber = bigBody.layer;
        playAnimExplosion1 = false;
        playAnimExplosion2 = false;
    }

    // public void Update()
    // {
    //     Debug.Log("player1hp: "+hpbarP1.player1HP);
    //     Debug.Log("player2hp: "+hpbarP2.player2HP);
    // }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        enemyName = collision.gameObject.name;
        enemyTag = collision.gameObject.tag;
        if (bigBodyNumber == 8)
        {
            meleeHit = 5f;
            projectileHit = 0f;
        }
        else if (bigBodyNumber == 9)
        {
            meleeHit = 20f;
            projectileHit = 2.5f;
        }
        else if (bigBodyNumber == 10)
        {
            meleeHit = 10f;
            projectileHit = 0f;
        }
        // if (alreadyHit == false)
        // {
        //     alreadyHit = true;
            if (enemyTag == "player2")
            {
                DMGed = true;
                playAnimExplosion1 = true;
                // Debug.Log("pulled");
                if (attachedTo.tag == "melee")
                {
                    if (hpbarP2.player2HP - meleeHit/40 >= 0)
                    {
                        hpbarP2.barPosition2.x -= meleeHit/40;
                        hpbarP2.player2HP = hpbarP2.player2HP - meleeHit;
                    }
                    else if (hpbarP2.player2HP - meleeHit/40  <= 0)
                    {
                        hpbarP2.barPosition2.x -= 0;
                        hpbarP2.player2HP = 0;
                        // Debug.Log("Running");
                    }
                }
                if (attachedTo.tag == "projectile")
                {
                    if (hpbarP2.player2HP - projectileHit/40 >= 0)
                    {
                        hpbarP2.barPosition2.x -= projectileHit/40;
                        hpbarP2.player2HP = hpbarP2.player2HP - projectileHit;
                    }
                    else if (hpbarP2.player2HP - projectileHit/40  <= 0)
                    {
                        hpbarP2.barPosition2.x -= 0;
                        hpbarP2.player2HP = 0;
                    }
                }    
            }
            if (enemyTag == "player1")
            {
                DMGed = true;
                playAnimExplosion2 = true;
                // Debug.Log("pulled");
                if (attachedTo.tag == "melee")
                {
                    if (hpbarP2.player2HP - meleeHit/40 >= 0)
                    {
                        hpbarP1.barPosition1.x -= meleeHit/40;
                        hpbarP1.player1HP = hpbarP1.player1HP - meleeHit; 
                    }
                    else if (hpbarP2.player2HP - meleeHit/40  <= 0)
                    {
                        hpbarP1.barPosition1.x -= 0;
                        hpbarP1.player1HP = 0;
                    }
                }
                if (attachedTo.tag == "projectile")
                {
                    if (hpbarP2.player2HP - projectileHit/40 >= 0)
                    {
                        hpbarP1.barPosition1.x -= projectileHit/40;
                        hpbarP1.player1HP = hpbarP1.player1HP - projectileHit; 
                    }
                    else if (hpbarP2.player2HP - projectileHit/40  <= 0)
                    {
                        hpbarP1.barPosition1.x -= 0;
                        hpbarP1.player1HP = 0;
                    }
                }
            }
        // }
        // else
        // {
        //     alreadyHit = false;
        // }
    }
}
