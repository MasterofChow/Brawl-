using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// The script waits for the two brawlers to say their voice lines
// Then waits and plays the "Lets Fight" audio
// Then finally starts the game

public class startGame : MonoBehaviour
{
    public static bool freezeMovementNotYet;
    public static int howMany;
    public static bool firstPlay;
    public static bool gameStart = false;
    private AudioSource source;
    public GameObject letsFightText;

    // Start is called before the first frame update
    void Start()
    {
        freezeMovementNotYet = true;
        howMany = 0;
        // Debug.Log(howMany);
        // Debug.Log(firstPlay);
        letsFightText.SetActive(false);
        firstPlay = true;
        source = GetComponent<AudioSource>();
    }

    void Update()
    {
        // Debug.Log(howMany);
        if (howMany == 2 && firstPlay == true)
        {
            firstPlay = false;
            Invoke("delayPlayLetsFight", 5f);
        }
    }

    void delayPlayLetsFight()
    {
        letsFightText.SetActive(true);
        source.Play();
        gameStart = true;
        // Debug.Log("gameStarted");
        StartCoroutine(hideText());
    }

    IEnumerator hideText()
    {
        yield return new WaitForSeconds (1f);
        letsFightText.SetActive(false);
    }
}
