using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class energyBallSF : MonoBehaviour
{
    public GameObject whosSound;
    private AudioSource source;
    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();   
    }

    // Update is called once per frame
    void Update()
    {
        if (whosSound.layer == 9)
        {
            if (whosSound.tag == "player1")
            {
                if(Input.GetKeyDown(KeyCode.R))
                {
                    source.Play();
                }
            }
            else if (whosSound.tag == "player2")
            {
                if (Input.GetKeyDown(KeyCode.N))
                {
                    source.Play();
                }
            }
        }
    }
}
