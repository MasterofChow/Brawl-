using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This is the second version of the hit sound effect script
// It makes the correct sound when a brawler is damaged

public class hitSF2 : MonoBehaviour
{
    public AudioClip hit1R;
    public AudioClip hit2R;
    public AudioClip hit1S;
    public AudioClip hit2S;
    public AudioClip hit1G;
    public AudioClip hit2G;

    private int whatNoise;
    private AudioSource source;
    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();   
    }

    // Update is called once per frame
    // Everyone but Rabidon has two hit sound effects
    void Update()
    {
        // Randomize the hit sound effect
        whatNoise = Random.Range(0,2);
        if (hitDetection.DMGed == true)
        {
            // For Shenzu
            if (hitDetection.enemyName == "Shenzu")
            {
                
                if (whatNoise == 0)
                {
                    // Debug.Log("play 1");
                    source.clip = hit1S;
                }
                else if (whatNoise == 1)
                {
                    // Debug.Log("play 2");
                    source.clip = hit2S;
                }
            }
            // For Rabidon
            else if (hitDetection.enemyName == "Rabidon")
            {
                // Debug.Log("Rabidon");
                if (whatNoise == 0)
                {
                    // Debug.Log("play 1");
                    source.clip = hit1R;
                }
                else if (whatNoise == 1)
                {
                    // Debug.Log("play 2");
                    source.clip = hit2R;
                }
            }
            // For Turon
            else if (hitDetection.enemyName == "Turon")
            {
                if (whatNoise == 0)
                {
                    // Debug.Log("play 1");
                    source.clip = hit1G;
                }
                else if (whatNoise == 1)
                {
                    // Debug.Log("play 2");
                    source.clip = hit2G;
                }
            }
            source.Play();
        }
        hitDetection.DMGed = false;
    }
}