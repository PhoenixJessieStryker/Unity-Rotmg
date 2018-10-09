using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{


    /*
    public GameObject explosionPrefab, gameOverText, restartButton;
    public RoadObstacle hurtObstacle;
    public RoadObstacle healObstacle;
    public RoadObstacle braveObstacle;
    public RoadObstacle fearObstacle;
    */

    public float speed;             //Floating point variable to store the player's movement speed.

    private Rigidbody2D rb;       //Store a reference to the Rigidbody2D component required to use 2D Physics.

    // Use this for initialization
    void Start()
    {
        //Get and store a reference to the Rigidbody2D component so that we can access it.
        rb = GetComponent<Rigidbody2D>();
    }

    //FixedUpdate is called at a fixed interval and is independent of frame rate. Put physics code here.
    void FixedUpdate()
    {
        //Store the current horizontal input in the float moveHorizontal.
        float moveHorizontal = Input.GetAxis("Horizontal");

        //Store the current vertical input in the float moveVertical.
        float moveVertical = Input.GetAxis("Vertical");

        //Use the two store floats to create a new Vector2 variable movement.
        Vector2 movement = new Vector2(moveHorizontal, moveVertical);

        //Call the AddForce function of our Rigidbody2D rb2d supplying movement multiplied by speed to move our player.
        rb.AddForce(movement * speed);
    }
    public void EndGame()
    {
        // giving it the game over property
        /*
        Instantiate(explosionPrefab, transform.position, Quaternion.identity);

 
        */
        gameObject.SetActive(false);
        gameObject.transform.position = new Vector3(0f, -3f, 0f);
    }



    void OnCollisionEnter2D(Collision2D col)
    {

        Debug.Log("col.gameObject.tag" + col.gameObject.tag);
        if (col.gameObject.tag.Equals("Enemy"))
        {
            EndGame();

        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        /*
        // ~~~~~~~~~~~~~Health Bar~~~~~~~~~~~~~~~~~
        // Debug.Log("this is working well , Hello Ben!");
        if (col.gameObject.tag.Equals("Collectible"))
        {
            col.gameObject.SetActive(false);
        }

        else if (col.gameObject.tag.Equals("Hurt"))
        {
            Debug.Log("That's Alot of Damage!");
            GetComponent<PlayerHP>().ChangeHP(-20f);


            hurtObstacle.DestroyObstacle(col.gameObject);
        }
        else if (col.gameObject.tag.Equals("Heal"))
        {
            Debug.Log("Youve been Healed!");
            GetComponent<PlayerHP>().ChangeHP(20f);
            healObstacle.DestroyObstacle(col.gameObject);
        }

        // ~~~~~~~~~~~~~~Section Off~~~~~~~~~~~~~~~~
        // ~~~~~~~~~~~~~~Progress Bar~~~~~~~~~~~~~~~
        Debug.Log("THis is Working Well Phoenix!");
        if (col.gameObject.tag.Equals("Collectible"))
        {
            col.gameObject.SetActive(false);
        }

        else if (col.gameObject.tag.Equals("Brave"))
        {
            Debug.Log("Collected Brave Behaviour!");
            GetComponent<ProgressBar>().ChangeProgress(20f);

            braveObstacle.DestroyObstacle(col.gameObject);
        }
        else if (col.gameObject.tag.Equals("Fear"))
        {
            Debug.Log("Collected Fear Behaviour!");
            GetComponent<ProgressBar>().ChangeProgress(-20f);
            fearObstacle.DestroyObstacle(col.gameObject);
        }
    }
    */
    }
}

/*
// Use this for initialization
void Start()
{

}

// Update is called once per frame
void Update()
{

    if (Input.GetKey(KeyCode.LeftArrow))
    {
        gameObject.transform.Translate(Vector3.left * 0.1f);
    }
    if (Input.GetKey(KeyCode.RightArrow))
    {
        gameObject.transform.Translate(Vector3.right * 0.1f);
    }
}
 */
