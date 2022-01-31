using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// As the title of the script is labeled it continues the background music started in the opening screen
// If the player enters the Fighting Stage then the music turns off

public class continueBackgroundMusic : MonoBehaviour
{
    private AudioSource source;
    public AudioClip backgroundMusic;
    public static bool started;
    // Start is called before the first frame update
    void Start()
    {
        // source.clip = backgroundMusic;
        source = GetComponent<AudioSource>();
        DontDestroyOnLoad(this.gameObject);
    }
    
    void Update()
    {
        // Debug.Log(started);
        if (enterFightingStageScene.turnOffMusic == true)
        {
            source.Stop();
            started = true;
        }
        else if (started == true)
        {
            Debug.Log("hello");
            source.Play();
            started = false;
        }
    }
}
