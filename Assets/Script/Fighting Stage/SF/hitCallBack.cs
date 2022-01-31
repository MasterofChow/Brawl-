using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Allows to see who is hit and who is attacking so we know what hit sound effect to be created 

public class hit : MonoBehaviour
{
    public GameObject rightHB;
    public GameObject leftHB;
    public static int whoHit;
    private void OnCollisionEnter2D (Collision2D collision)
    {
        // Debug.Log("check1");
        if (rightHB.activeSelf == true || leftHB.activeSelf == true)
        {
            // Debug.Log("check2");
            if (gameObject.name == "Rabidon")
            {
                whoHit = 0;
            }
            else if (gameObject.name == "Shenzu")
            {
                whoHit = 1;
            }
            else if (gameObject.name == "Turon")
            {
                whoHit = 2;
            }
        }
    }
}
