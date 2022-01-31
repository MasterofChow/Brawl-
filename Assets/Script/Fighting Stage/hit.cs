using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hitCallBack : MonoBehaviour
{
    public GameObject rightHB;
    public GameObject leftHB;
    public static int whoHit;
    private void OnCollisionEnter2D (Collision2D collision)
    {
        if (rightHB.activeSelf || leftHB.activeSelf)
        {
            if (gameObject.name == "Rabidon")
            {
                whoHit = 0;
            }
            else if (gameObject.name == "Shenzu")
            {
                whoHit = 1;
            }
            else if (gameObject.name == "Gaeman")
            {
                whoHit = 2;
            }
        }
    }
}
