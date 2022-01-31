using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playPlayerOneWins : MonoBehaviour
{
    public AudioSource source;
    
    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playDeathAnimation.sendToAnotherScripttoPlayAudioPlayer1 == true)
        {
            Debug.Log("play1");
            source.Play();
            playDeathAnimation.playedOnce = true;
            playDeathAnimation.sendToAnotherScripttoPlayAudioPlayer1 = false;
            playDeathAnimation.sendToAnotherScripttoPlayAudioPlayer2 = false;
        }
    }
}
