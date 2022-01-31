using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// I have a chooseCharacter1 b/c some variables had to be specific to player2

public class chooseCharacter2 : MonoBehaviour
{
    public static Vector3 position;
    public static bool select2 = false;
    public GameObject Shenzu;
    public GameObject Rabidon;
    public GameObject Gaeman;
    public int selectionNumber;
    public static int numberTag;
    private AudioSource source;
    public AudioClip shenzuName;
    public AudioClip rabidonName;
    public AudioClip gaemanName;

    void Start()
    {
        source = GetComponent<AudioSource>();

        // I have to preset the AudioSource
        source.clip = shenzuName;

        numberTag = 10;

        // selectionNumber allows me to know which character is selected when 'm' is pressed
        selectionNumber = 2;

        select2 = false;

        Vector3 position = new Vector3 (8.5f, 4f, -4f);
    }
    void Update()
    {
        // Allow player2 to move left and right
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            position = transform.position;
            if (position.x + 5.9 <= 21.8)
            {
                position.x += 5.9f;
                transform.position = position;
                selectionNumber += 1;
            }
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            position = transform.position;
            if (position.x - 5.9 >= 9.9)
            {
                // Debug.Log("moved");
                position.x -= 5.9f;
                transform.position = position;
                selectionNumber -= 1;
            }
        }
        // Select - which changes the outline
        if (Input.GetKeyDown(KeyCode.M))
        {
            // I pre-tag all the characters and switch the tag to the player which selects it
            // , so that the other player cannot also select the character
            if (selectionNumber == 0)
            {
                if (Shenzu.tag == "Shenzu" && select2 == false)
                {
                    numberTag = selectionNumber;
                    Shenzu.tag = "player2";
                    select2 = true;
                    source.clip = shenzuName;
                    source.Play();
                }
                else if (Shenzu.tag == "player2")
                {
                    Shenzu.tag = "Shenzu";
                    select2 = false;
                    numberTag = 10;
                }
            }
            if (selectionNumber == 1)
            {
                if (Rabidon.tag == "Rabidon" && select2 == false)
                {
                    numberTag = selectionNumber;
                    Rabidon.tag = "player2";
                    select2 = true;
                    source.clip = rabidonName;
                    source.Play();
                }
                else if (Rabidon.tag  == "player2")
                {
                    Rabidon.tag = "Rabidon";
                    select2 = false;
                    numberTag = 10;
                }
            }
            if (selectionNumber == 2)
            {
                if (Gaeman.tag == "Gaeman" && select2 == false)
                {
                    numberTag = selectionNumber;
                    Gaeman.tag = "player2";
                    select2 = true;
                    source.clip = gaemanName;
                    source.Play();
                }
                else if (Gaeman.tag == "player2")
                {
                    Gaeman.tag = "Gaeman";
                    select2 = false;
                    numberTag = 10;
                }
            }
        }
        // Debug.Log("select2: " + selectionNumber);
    }
}
