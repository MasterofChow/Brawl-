using System.Collections;
using UnityEngine.UI;
using UnityEngine;

// Controls all of the brawlers movements

[RequireComponent(typeof(SpriteRenderer))]
[RequireComponent(typeof(Animator))]
public class movementControls : MonoBehaviour {
    SpriteRenderer Srend;
    public Animator anim;

    public GameObject topRight;

    public GameObject topLeft;

    public GameObject botRight;

    public GameObject botLeft;

    private Rigidbody2D rb;

    public static bool lookDirection1;

    public static bool lookDirection2;

    //change these variables if you wish to test different speeds and jump heights
    [SerializeField]
    public float horizontalForce = 1f;
    public float jumpForce = 10f;

    float horizontalMove = 0f;

    void Start()
    {
        // Confirms player1's brawler looks right and player2's brawlers looks left
        Srend = GetComponentInChildren<SpriteRenderer>();
        anim = GetComponentInChildren<Animator>();
        if (gameObject.CompareTag("player1"))
        {
            anim.SetBool("lookRight", true);
        }
        if (gameObject.CompareTag("player2"))
        {
            anim.SetBool("lookRight", false);
        }

        rb = transform.GetComponent<Rigidbody2D> ();
        anim.SetBool("idle", true);
    }
    // Update is called once per frame
    void Update () 
    {
        if (gameObject.tag == "player1")
        {
            lookDirection1 = anim.GetBool("lookRight");
        }
        if (gameObject.tag == "player2")
        {
            lookDirection2 = anim.GetBool("lookRight");
        }
        // Do not want for characters to move if the audios have not played yet
        if (startGame.gameStart == true && startGame.freezeMovementNotYet == true)
        {
            if (anim.GetBool("lookRight") == true)
            {
                topRight.SetActive(true);
                botRight.SetActive(true);
                topLeft.SetActive(false);
                botLeft.SetActive(false);
            }
            else if(anim.GetBool("lookRight") == false)
            {
                topRight.SetActive(false);
                botRight.SetActive(false);
                topLeft.SetActive(true);
                botLeft.SetActive(true);
            }
            horizontalMove = Input.GetAxisRaw("Horizontal") * horizontalForce;
            // Player 1's movement control
            if (gameObject.CompareTag("player1"))
            {
                // Debug.Log("reading");
                if (Input.GetKeyDown(KeyCode.W))
                {
                    rb.velocity = Vector2.up * jumpForce;
                }

                if (Input.GetKey(KeyCode.D))
                {
                    anim.SetBool("idle", false);
                    anim.SetBool("lookRight", true);
                    transform.Translate(Vector2.right * Time.fixedDeltaTime * horizontalForce);
                    Invoke("SetisAttackingFalse", .05f);
                }

                if (Input.GetKey(KeyCode.A))
                {
                    anim.SetBool("idle", false);
                    anim.SetBool("lookRight", false);
                    transform.Translate(Vector2.left * Time.fixedDeltaTime * horizontalForce);
                    Invoke("SetisAttackingFalse", .05f);
                }    

                if (Input.GetKeyDown(KeyCode.T))
                {
                    anim.SetBool("idle", false);
                    anim.SetBool("isAttacking", true);
                    Invoke("SetisAttackingFalse", .25f);
                }
                if (Input.GetKeyDown(KeyCode.R))
                {
                    anim.SetBool("idle", false);
                    anim.SetBool("isAttacking",true);
                    anim.SetBool("projectile", true);
                    Invoke("SetisAttackingFalse", .05f);
                    // Debug.Log("Whats Going On");
                }
            }
            // Player 2's movement control
            if (gameObject.CompareTag("player2"))
            {
                // Debug.Log("reading");
                if (Input.GetKeyDown(KeyCode.UpArrow))
                {
                    rb.velocity = Vector2.up * jumpForce;
                }

                if (Input.GetKey(KeyCode.RightArrow))
                {
                    anim.SetBool("idle", false);
                    anim.SetBool("lookRight", true);
                    transform.Translate(Vector2.right * Time.fixedDeltaTime * horizontalForce);
                    Invoke("SetisAttackingFalse", .05f);
                }

                if (Input.GetKey(KeyCode.LeftArrow))
                {
                    anim.SetBool("idle", false);
                    anim.SetBool("lookRight", false);
                    transform.Translate(Vector2.left * Time.fixedDeltaTime * horizontalForce);
                    Invoke("SetisAttackingFalse", .05f);
                }    

                if (Input.GetKeyDown(KeyCode.M))
                {
                    anim.SetBool("idle", false);
                    anim.SetBool("isAttacking", true);
                    Invoke("SetisAttackingFalse", .25f);
                }
                if (Input.GetKeyDown(KeyCode.N))
                {
                    anim.SetBool("idle", false);
                    anim.SetBool("isAttacking",true);
                    anim.SetBool("projectile", true);
                    Invoke("SetisAttackingFalse", .05f);
                    // Debug.Log("Whats Going On");
                }
            }
        }
    }

    // Resets the attacking values
    private void SetisAttackingFalse()
    {
        anim.SetBool("isAttacking", false);
        anim.SetBool("projectile", false);
        anim.SetBool("idle", true);
    }
}