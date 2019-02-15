using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
   

    public Text healthText;

    private Rigidbody2D rb2d;
    //private Animator Anim;
    private SpriteRenderer SpRend;
    public int PlayerHealth = 100;
    public GameObject SharkEnemy;
    private bool isGrounded = false;
    private bool Jump;

    private int SharkDmg = 25;

    private int seaDmg = 15;

    [SerializeField]
    private float moveSpeed = 10f;
    [SerializeField]
    private float jumpForce = 100f;
    [SerializeField]
    private Transform groundCheck;
    [SerializeField]
    private float groundCheckRadius = 0.2f;







    // Jumping 
    void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
        //Anim = GetComponent<Animator>();
        SpRend = GetComponent<SpriteRenderer>();

        groundCheck = transform.Find("GroundCheck");

        SharkEnemy = GameObject.FindGameObjectWithTag("SharkEnemy");
    }

    // Jumping
    void Update()

    {

        isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, LayerMask.GetMask("Ground"));

        if (Input.GetButtonDown("Jump") && isGrounded)
            Jump = true;
    }

    

    public void AddHealth()
    {

        healthText.text = "Health:" + PlayerHealth.ToString();
    }

    // Player Movement
    void FixedUpdate()



    {
        AddHealth();

        float horizontal = Input.GetAxis("Horizontal");
        Move(horizontal);
    }
    private void Move(float horizontal)
    {
        rb2d.velocity = new Vector2(horizontal * moveSpeed, rb2d.velocity.y);


        if (Jump)
        {
            rb2d.AddForce(new Vector2(0f, jumpForce));
            Jump = false;

        }

        if (horizontal > 0)
        {
            SpRend.flipX = false;
        }

        else if (horizontal < 0)
        {
            SpRend.flipX = true;
        }

        {


        }
    }

    //Health

    void Start()
    {
        print(PlayerHealth);
        

    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "SharkEnemy")
        {
            PlayerHealth -= SharkDmg;

            print("Ouch" + PlayerHealth);
        }

        if (col.gameObject.tag == "SeaCreature")
        {
            PlayerHealth -= seaDmg;

            print("Ouchie" + PlayerHealth);

           
        }

        if (PlayerHealth <= 0)
        {
            Destroy(gameObject);
            SceneManager.LoadScene("GameOver");
        }



    }
}
