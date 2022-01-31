using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// The shows the text that notifies the player to press 'Enter'

public class characterSelected : MonoBehaviour
{
    public GameObject fightText;

    // Update is called once per frame
    void Update()
    {
        if (chooseCharacter1.select1 == true && chooseCharacter2.select2 == true)
        {
            if (gameObject.name == "textBack")
            {
                fightText.transform.position = new Vector3(.75f,2.375f,1f);
            }
            else 
            {
                fightText.transform.position = new Vector3(12.9f,7.4f,-19f);
            }
        }
        else 
        {
            fightText.transform.position = new Vector3(0f,-.5f,10f);
        }
    }
}
