using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// In the opening scene, if "Enter" is pressed it continues to the 'Character Select' Scene
// Once the type writing effect is done of Ubrawl then it shows the Enter text

public class flashEnter : MonoBehaviour
{
    public MeshRenderer mesh;
    // Start is called before the first frame update
    void Start()
    {
        mesh = GetComponent<MeshRenderer>();
        mesh.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (ubrawlReveal.doneWithText == true)
        {
            mesh.enabled = true;
        }
        if (Input.GetKeyDown(KeyCode.Return))
        {
            SceneManager.LoadScene("Character Select");
        }
    }
}
