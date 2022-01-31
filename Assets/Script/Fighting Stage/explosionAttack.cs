using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class explosionAttack : MonoBehaviour
{
    public Animator anim;
    public GameObject parentBody;
    public SpriteRenderer meshR;
    public SpriteRenderer meshL;
    private int whatImage;
    private int holdImage;

    // Start is called before the first frame update
    void Start()
    {
        whatImage = 0;
        if (parentBody.tag == "player1")
        {
            anim.SetBool("player1", true);
        }
        else if (parentBody.tag == "player2")
        {
            anim.SetBool("player1", false);
        }
        meshR.enabled = false;
        meshL.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (parentBody.tag == "player1")
            if (hitDetection.playAnimExplosion1 == true && movementControls.lookDirection1 == true)
            {
                // Debug.Log("hola1");
                whatImage = Random.Range(0,2);
                meshR.enabled = true;
            }
            else if (hitDetection.playAnimExplosion1 == true && movementControls.lookDirection1 == false)
            {
                // Debug.Log("hola2");
                whatImage = Random.Range(0,2);
                meshL.enabled = true;
            }
        if (parentBody.tag == "player2")
        {
            if (hitDetection.playAnimExplosion2 == true && movementControls.lookDirection2 == true)
            {
                // Debug.Log("hola1");
                whatImage = Random.Range(0,2);
                meshR.enabled = true;
            }
            else if (hitDetection.playAnimExplosion2 == true && movementControls.lookDirection2 == false)
            {
                // Debug.Log("hola2");
                whatImage = Random.Range(0,2);
                meshL.enabled = true;
            }
        }
        if (meshR.enabled == true)
        {
            holdImage = whatImage;
            anim.SetInteger("whichAnimation", holdImage);
            if (parentBody.layer == 8)
            {
                StartCoroutine(setRabidonFalse());
            }
            else if (parentBody.layer == 9)
            {
                StartCoroutine(setShenzuFalse());
            }
            else if (parentBody.layer == 10)
            {
                StartCoroutine(setGaemanFalse());
            }
        }
        else if (meshL.enabled == true)
        {
            holdImage = whatImage;
            anim.SetInteger("whichAnimation", holdImage);
            if (parentBody.layer == 8)
            {
                StartCoroutine(setRabidonFalse());
            }
            else if (parentBody.layer == 9)
            {
                StartCoroutine(setShenzuFalse());
            }
            else if (parentBody.layer == 10)
            {
                StartCoroutine(setGaemanFalse());
            }
        }
    }
    IEnumerator setRabidonFalse()
    {
        yield return new WaitForSeconds(.5f);
        meshR.enabled = false;
        meshL.enabled = false;
        hitDetection.playAnimExplosion1 = false;
        hitDetection.playAnimExplosion2 = false;
    }

    IEnumerator setShenzuFalse()
    {
        yield return new WaitForSeconds(.25f);
        meshR.enabled = false;
        meshL.enabled = false;
        hitDetection.playAnimExplosion1 = false;
        hitDetection.playAnimExplosion2 = false;
    }

    IEnumerator setGaemanFalse()
    {
        yield return new WaitForSeconds(.25f);
        meshR.enabled = false;
        meshL.enabled = false;
        hitDetection.playAnimExplosion1 = false;
        hitDetection.playAnimExplosion2 = false;
    }
}
