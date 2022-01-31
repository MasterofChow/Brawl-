using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This class randomizes the background of the fighting stage

public class randomBackground : MonoBehaviour
{
    public int randomBackgroundNumber;
    public GameObject forest;
    public GameObject waterfalls;
    public GameObject shipyard;
    public GameObject temple;
    // Start is called before the first frame update
    void Start()
    {
        forest.SetActive(false);
        waterfalls.SetActive(false);
        shipyard.SetActive(false);
        temple.SetActive(false);
        randomBackgroundNumber = Random.Range(0,4);
        // Set forest background
        if (randomBackgroundNumber == 0)
        {
            forest.SetActive(true);
            forest.transform.position = new Vector3(-.04f, 10.1f, 100f);
        }
        // Set Waterfall background
        else if (randomBackgroundNumber == 1)
        {
            waterfalls.SetActive(true);
            waterfalls.transform.position = new Vector3(.1f, 9.8f, 100f);
        }
        // Set Temple background
        else if (randomBackgroundNumber == 2)
        {
            temple.SetActive(true);
            temple.transform.position = new Vector3(0f, 10.8f, 100f);
        }
        // Set Shipyard background
        else if (randomBackgroundNumber == 3)
        {
            shipyard.SetActive(true);
            shipyard.transform.position = new Vector3(-.1f, 9.2f, 100f);
        }
    }
}
