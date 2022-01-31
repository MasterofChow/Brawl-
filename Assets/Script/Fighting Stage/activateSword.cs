using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This is the special animation for Turon because Turon needed more of a delay for activating and deactivating his hitbox
// The attack animation for Turon is longer

public class activateSword : MonoBehaviour
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
        if (startGame.gameStart == true)
        {
            if (gameObject.tag == "player1")
            {
                if (Input.GetKey(KeyCode.T) && !attacking)
                {
                    attacking = true;

                    attackTimer = attackCoolDown;

                    direction = anim.GetBool("lookRight");
                    if (direction == true)
                    {
                        Invoke("activateRight", .3f);
                        //Debug.Log("rightHB");

                    }
                    else if (direction == false)
                    {
                        Invoke("activateLeft", .3f);
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
                        Invoke("activateRight", .3f);
                    }
                    else if (direction == false)
                    {
                        attacking = true;
                        Invoke("activateLeft", .3f);
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

    public void activateRight()
    {
        attacking = true;
        rightHB.SetActive(true);
    }

    public void activateLeft()
    {
        attacking = true;
        leftHB.SetActive(true);
    }
}
