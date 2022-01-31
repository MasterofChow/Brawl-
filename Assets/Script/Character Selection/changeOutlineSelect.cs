using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Class changes the outline of the brawler in the Character Selection Scene

public class changeOutlineSelect : MonoBehaviour
{
    public GameObject attachedTo;
    public Color player1Color;
    public Color player2Color;
    public Color black;
    MeshRenderer myRenderer;

    // Start is called before the first frame update
    void Start()
    {
        // Put the script on the outline to get the correct color
        myRenderer = GetComponent<MeshRenderer> ();
    }

    // Update is called once per frame
    void Update()
    {
        // I set the colors with color materials I made
        if (attachedTo.tag == "player1")
        {
            myRenderer.material.color = player1Color;
        }
        else if (attachedTo.tag == "player2")
        {
            myRenderer.material.color = player2Color;
        }
        else if (attachedTo.tag != "player1" || attachedTo.tag != "player2")
        {
            myRenderer.material.color = black;
        }
    }
}
