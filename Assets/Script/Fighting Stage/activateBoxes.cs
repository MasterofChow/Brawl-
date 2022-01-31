using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Used for detecting if when a player attacks contact is made with the opposing player

public class activateBoxes : MonoBehaviour
{
    private bool attacking = false;

    private bool direction = true;

    private float attackTimer = 0;

    private float attackCoolDown = .45f;

    public GameObject rightHB;

    public GameObject leftHB;

    private Animator anim;

    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
        rightHB.SetActive(false);
        leftHB.SetActive(false);
    }

    void Update()
    {
        // Make sure game has started
        if (startGame.gameStart == true && startGame.freezeMovementNotYet == true)
        {
            // Checks which player script is attached to
            if (gameObject.tag == "player1")
            {
                // If attack button is pressed
                if (Input.GetKey(KeyCode.T) && !attacking)
                {
                    attacking = true;

                    attackTimer = attackCoolDown;

                    // Activates the appropriate attack box 
                    direction = anim.GetBool("lookRight");
                    if (direction == true)
                    {
                        attacking = true;
                        rightHB.SetActive(true);
                        //Debug.Log("rightHB");

                    }
                    else if (direction == false)
                    {
                        attacking = true;
                        leftHB.SetActive(true);
                        //Debug.Log("leftHB");
                    }
                }
                if (attacking == true)
                {
                    if (attackTimer > 0)
                    {
                        attackTimer -= Time.deltaTime;
                    }
                    else
                    {
                        attacking = false;
                        rightHB.SetActive(false);
                        leftHB.SetActive(false);
                    }
                }
            }
            else if (gameObject.tag == "player2")
            {
                if (Input.GetKey(KeyCode.M) && !attacking)
                {
                    attacking = true;

                    attackTimer = attackCoolDown;

                    direction = anim.GetBool("lookRight");
                    if (direction == true)
                    {
                        attacking = true;
                        rightHB.SetActive(true);
                    }
                    else if (direction == false)
                    {
                        attacking = true;
                        leftHB.SetActive(true);
                    }
                }
                if (attacking == true)
                {
                    if (attackTimer > 0)
                    {
                        attackTimer -= Time.deltaTime;
                    }
                    else
                    {
                        attacking = false;
                        rightHB.SetActive(false);
                        leftHB.SetActive(false);
                    }
                }
            }
        }
    }
}
