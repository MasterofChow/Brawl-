using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeWalkVolume : MonoBehaviour
{
    public GameObject ground;
    AudioSource source;
    private float baseLine;
    // Start is called before the first frame update
    void Start()
    {
        baseLine = ground.transform.position.y;
        source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        source.volume = (transform.position.y - baseLine)*.05f;
        source.Play();
    }
}
