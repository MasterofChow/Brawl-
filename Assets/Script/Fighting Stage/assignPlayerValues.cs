using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Assigns values to the brawlers to allow them to be tagged as either player 1 or player 2

public class assignPlayerValues : MonoBehaviour
{
    public GameObject Shenzu;
    public GameObject Rabidon;
    public GameObject Gaeman;
    public GameObject shenzuName;
    public GameObject rabidonName;
    public GameObject gaemanName;
    public static int assign1;
    public static int assign2;
    // Start is called before the first frame update
    void Awake()
    {
        Shenzu.SetActive(true);
        Rabidon.SetActive(true);
        Gaeman.SetActive(true);
        // I have them pre-assign to test the Fighting Stage without having to go into the Character Selection Stage
        // assignTagFighting.assign1Tag = 0;
        // assignTagFighting.assign2Tag = 1;
        assign1 = assignTagFighting.assign1Tag;
        assign2 = assignTagFighting.assign2Tag;
        // Debug.Log(assign1);
        // Debug.Log(assign2);
        if (assign1 == 0)
        {
            Shenzu.tag = "player1";
            Shenzu.transform.position = new Vector3 (-9,6.4f,-3);
            shenzuName.transform.position = new Vector3 (-2.3f,14.15f,-7.875f);
        }
        else if (assign1 == 1)
        {
            Rabidon.tag = "player1";
            Rabidon.transform.position = new Vector3 (-9,6.4f,-3);
            rabidonName.transform.position = new Vector3 (-2.3f,14.15f,-7.875f);
        }
        else if (assign1 == 2)
        {
            Gaeman.tag = "player1";
            Gaeman.transform.position = new Vector3 (-9,6.4f,-3);
            gaemanName.transform.position = new Vector3 (-2.3f,14.15f,-7.875f);
        }
        if (assign2 == 0)
        {
            Shenzu.tag = "player2";
            Shenzu.transform.position = new Vector3 (9,6.4f,-3);
            shenzuName.transform.position = new Vector3 (16.3f,14.15f,-7.875f);
        }
        else if (assign2 == 1)
        {
            Rabidon.tag = "player2";
            Rabidon.transform.position = new Vector3 (9,6.4f,-3);
            rabidonName.transform.position = new Vector3 (16.3f,14.15f,-7.875f);
        }
        else if (assign2 == 2)
        {
            Gaeman.tag = "player2";
            Gaeman.transform.position = new Vector3 (9,6.4f,-3);
            gaemanName.transform.position = new Vector3 (16.3f,14.15f,-7.875f);
        }
    }
}
