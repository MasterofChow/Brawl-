using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Allows player 1 to select a brawler and have the brawler show up
// in the right position in the Fighting Stage

public class assignTagFighting : MonoBehaviour
{
    public static int assign1Tag;
    public static int assign2Tag;
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        assign1Tag = chooseCharacter1.numberTag;
        assign2Tag = chooseCharacter2.numberTag;
    }
}
