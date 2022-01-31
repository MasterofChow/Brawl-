using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// The script is attached to each brawler and starts each brawler's opening

public class playIntro : MonoBehaviour
{
    private AudioSource source;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(delayAudioStart());
    }

    IEnumerator delayAudioStart()
    {
        yield return new WaitForSeconds(1f);
        source = GetComponent<AudioSource>();
        if (gameObject.tag == "player1")
        {
            // Debug.Log("added");
            startGame.howMany = 1 + startGame.howMany;
            source.Play();
        }
        else if (gameObject.tag == "player2")
        {
            // Debug.Log("added");
            Invoke("waitPlay", 2f);
            startGame.howMany = 1 + startGame.howMany;
        }
    }

    void waitPlay()
    {
        source.Play();
    }
}
