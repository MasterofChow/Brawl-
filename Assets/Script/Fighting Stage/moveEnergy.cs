using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveEnergy : MonoBehaviour
{
    public Animator anim;
    public SpriteRenderer mesh;
    static Vector3 ballLocation;
    static Vector3 parentLocation;
    public GameObject energyBallCopy;
    public GameObject energyBallSize;
    public GameObject parentBody;
    public Rigidbody2D rb;
    public Collider2D energyBallCollider;
    private bool attacking;
    public float speed = 20f;
    private AudioSource source;
    Vector3 addition = new Vector3 (1f, 1f, 0f);

    void Start()
    {
        source = GetComponent<AudioSource>(); 
        // energyBallCollider = GetComponent<Collider2D>();
        Vector3 addition = new Vector3 (1f, 1f, 0f);
        attacking = false;
        transform.position = parentBody.transform.position + addition;
        Reset();
    }

    private void Reset()
    {
        energyBallCollider.enabled = false;
        Vector3 addition = new Vector3 (0f, 3f, 0f);
        transform.position = parentBody.transform.position + addition;
        // energyBall.SetActive(false);
        mesh.enabled = false;
        attacking = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (startGame.gameStart == true)
        {
            transform.localScale = energyBallSize.GetComponent<Renderer>().bounds.size;
            //Debug.Log("attacking: " + attacking);
            if (parentBody.GetComponent<Animator>().GetBool("lookRight") == true && attacking == false)
            {
                anim.SetBool("lookRight", true);
            }
            if (parentBody.GetComponent<Animator>().GetBool("lookRight") == false && attacking == false)
            {
                anim.SetBool("lookRight", false);
            }
            if (Input.GetKey(KeyCode.R) && parentBody.tag == "player1")
            {
                //Debug.Log("enabled");
                energyBallCollider.enabled = true;
                mesh.enabled = true;
                attacking = true;            
            }
            if (Input.GetKey(KeyCode.N) && parentBody.tag == "player2")
            {
                energyBallCollider.enabled = true;
                mesh.enabled = true;
                attacking = true;
            }
            if (attacking == false)
            {
                Reset();
            }
            if (attacking == true)
            {
                if (anim.GetBool("lookRight") == true)
                {
                    rb.velocity = transform.right * speed; 
                }
                else
                {
                    rb.velocity = (-1f) * transform.right * speed;
                }
            }
        }
    }

    private void OnCollisionEnter2D (Collision2D collision)
    {
        if (collision.gameObject.tag != parentBody.tag)
        {
            parentLocation = parentBody.transform.position + addition;

            source.Play();

            Instantiate (energyBallCopy, parentLocation, Quaternion.identity);

            Destroy(gameObject);

            Reset();
        }
    }
}
