using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// As the title of suggest - the script activates the attack noises when a brawler attacks

public class produceAttackNoise : MonoBehaviour
{
    private AudioSource source;
    public GameObject parentBody;
    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (startGame.gameStart == true)
        {
            if (parentBody.tag == "player1")
            {
                if (Input.GetKeyDown(KeyCode.T))
                {
                    source.Play();
                }
            }
            else if (parentBody.tag == "player2")
            {
                if (Input.GetKeyDown(KeyCode.M))
                {
                    source.Play();
                }
            }
        }
    }
}
