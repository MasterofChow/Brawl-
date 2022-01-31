using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Shows the trophies under each player health bar

public class showTrophies : MonoBehaviour
{
    static Vector3 trophy1Vector; 
    static Vector3 trophy2Vector;
    public GameObject originalTrophy1;
    public GameObject originalTrophy2;
    public GameObject trophyGoldCopy;
    public GameObject trophySilverCopy;
    Vector3 addition1 = new Vector3 (1.5f, 0f, 0f);
    Vector3 addition2 = new Vector3 (-1.5f, 0f, 0f);
    // Start is called before the first frame update
    public int player1Trophies = 0;
    public int player2Trophies = 0;
    public int tempAdd1 = 0;
    public int tempAdd2 = 0;
    void Start()
    {
        // I put trophies with their meshes off where i want them to be so I can add to their location
        trophy1Vector = originalTrophy1.transform.position;
        trophy2Vector = originalTrophy2.transform.position;

        // Creates the gold trophies before the silver trophies for player1
        // Gold trophies are only shown if 1 player wins 5 times
        for (int i = player1Trophies; i < containWinners.player1Wins / 5; i++)
        {
            // Debug.Log("i: "+i);
            Instantiate(trophyGoldCopy, trophy1Vector, Quaternion.identity);
            trophy1Vector = originalTrophy1.transform.position + addition1;
            addition1 = addition1 + new Vector3(1.5f, 0f, 0f);
            tempAdd1 = i + 1;
        }
        player1Trophies = player1Trophies + (tempAdd1 * 5);
        // Debug.Log(player1Trophies);
        for (int m = player1Trophies; m < containWinners.player1Wins; m++)
        {
            // Debug.Log("m: "+m);
            Instantiate(trophySilverCopy, trophy1Vector, Quaternion.identity);
            trophy1Vector = originalTrophy1.transform.position + addition1;
            addition1 = addition1 + new Vector3(1.5f, 0f, 0f);
        }
        // Creates the gold trophies before the silver trophies for player2
        // Gold trophies are only shown if 1 player wins 5 times
        for (int g = player2Trophies; g < containWinners.player2Wins / 5; g++)
        {
            // Debug.Log("g: "+g);
            Instantiate(trophyGoldCopy, trophy2Vector, Quaternion.identity);
            trophy2Vector = originalTrophy2.transform.position + addition2;
            addition2 = addition2 + new Vector3(-1.5f, 0f, 0f);
            tempAdd2 = g;
        }
        player2Trophies = player2Trophies + (tempAdd2 * 5);
        // Debug.Log(player2Trophies);
        for (int j = 0; j < containWinners.player2Wins; j++)
        {
            // Debug.Log("j: "+j);
            Instantiate(trophySilverCopy, trophy2Vector, Quaternion.identity);
            trophy2Vector = originalTrophy2.transform.position + addition2;
            addition2 = addition2 + new Vector3(-1.5f, 0f, 0f);
        }
    }
}