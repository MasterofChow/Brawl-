using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chooseCharacter1 : MonoBehaviour
{
    public static Vector3 position;
    public static bool select1 = false;
    public GameObject Shenzu;
    public GameObject Rabidon;
    public GameObject Gaeman;
    public int selectionNumber;
    public static int numberTag;
    public AudioSource source;
    public AudioClip shenzuName;
    public AudioClip rabidonName;
    public AudioClip gaemanName;
    void Start()
    {
        source = GetComponent<AudioSource>();
        
        // Preset the audio clip
        source.clip = shenzuName;

        numberTag = 10;

        // Allows the player1 select to work and keeps track of which brawler it is on
        selectionNumber = 0;

        select1 = false;

        Vector3 position = new Vector3 (-6.5f, 2.8f, -4f);
    }
    void Update()
    {
        // Allows player1 to move left and right between the characters
        if (Input.GetKeyDown(KeyCode.D))
        {
            position = transform.position;
            if (position.x + 5.9f <= 18.6)
            {
                selectionNumber += 1;
                position.x += 5.9f;
                transform.position = position;
            }
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            position = transform.position;
            if (position.x - 5.9f >= 6.73)
            {
                selectionNumber -= 1;
                position.x -= 5.9f;
                transform.position = position;
            }
        }
        // Debug.Log("Selection Number: " + selectionNumber);
        // I pre-tag all the characters with their own name and switch the tag to the player which selects it
        // , so that the other player cannot also select the character
        if (Input.GetKeyDown(KeyCode.T))
        {
            if (selectionNumber == 0)
            {
                if (Shenzu.tag == "Shenzu" && select1 == false)
                {
                    numberTag = selectionNumber;
                    Shenzu.tag = "player1";
                    select1 = true;
                    source.clip = shenzuName;
                    source.Play();
                }
                else if (Shenzu.tag == "player1")
                {
                    numberTag = 10;
                    Shenzu.tag = "Shenzu";
                    select1 = false;
                }
            }
            if (selectionNumber == 1)
            {
                if (Rabidon.tag == "Rabidon" && select1 == false)
                {
                    numberTag = selectionNumber;
                    Rabidon.tag = "player1";
                    select1 = true;
                    source.clip = rabidonName;
                    source.Play();
                }
                else if (Rabidon.tag == "player1")
                {
                    numberTag = 10;
                    Rabidon.tag = "Rabidon";
                    select1 = false;
                }
            }
            if (selectionNumber == 2)
            {
                if (Gaeman.tag == "Gaeman" && select1 == false)
                {
                    numberTag = selectionNumber;
                    Gaeman.tag = "player1";
                    select1 = true;
                    source.clip = gaemanName;
                    source.Play();
                }
                else if (Gaeman.tag == "player1")
                {
                    Gaeman.tag = "Gaeman";
                    select1 = false;
                    numberTag = 10;
                }
            }
        }
        // Debug.Log("select1: " + selectionNumber);
    }
}
