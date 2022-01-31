using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// The class does two things:
// 1. Ends music that played at the beginning
// 2. Checks if 'Enter' is pressed and gets a boolean from chooseCharacter1 and chooseCharacter2 
//    to see if both players have selected a brawler
public class enterFightingStageScene : MonoBehaviour
{
    public static bool turnOffMusic;
    public AudioSource source;
    // Start is called before the first frame update
    void Start()
    {
        whoWon.winnerWW = 0;
        source = GetComponent<AudioSource>();
        // Debug.Log("hello");
    }

    // Update is called once per frame
    void Update()
    {
        turnOffMusic = false;
        // Debug.Log("chooseCharacter2.select2 = " + chooseCharacter2.select2);
        // Debug.Log("chooseCharacter1.select1 = " + chooseCharacter1.select1);
        // Checks if enter and both players have selected a brawler
        if (Input.GetKeyDown(KeyCode.Return) && chooseCharacter2.select2 == true && chooseCharacter1.select1 == true)
        {
            source.Play();
            // Debug.Log("Loaded");
            Invoke("LoadNext", 1);
        }
    }

    // Loads next level and turns off music
    public void LoadNext()
    {
        turnOffMusic = true;
        SceneManager.LoadScene("Fighting Stage");
    }
}
