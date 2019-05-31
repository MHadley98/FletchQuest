using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Extra using statment to allow us to use the scene management functions
using UnityEngine.SceneManagement;

public class Fletcher : MonoBehaviour {

    //designer variables
    public float speed = 10;
    public float jumpSpeed = 1;
    public float superJump = 5;
    public Rigidbody2D physicsBody;
    public string horizontalAxis = "Horizontal";
    public string jumpButton = "Jump";
    public string ttButton = "Time Travel";
    public string sceneToLoad;
    public Score scoreObject;
    public Lives livesObject;
    public AudioSource tt;

    public Animator fletcherAnimator;
    public SpriteRenderer playerSprite;
    public Collider2D playerCollider;



    // Use this for initialization
    void Start () {

        //Get player's position for tt
        Vector3 newPos = transform.position;
        newPos.x = PlayerPrefs.GetFloat("xPos", transform.position.x);
        newPos.y = PlayerPrefs.GetFloat("yPos", transform.position.y);

        transform.position = newPos;

    }
	
	// Update is called once per frame
	void Update () {


        //Get axis input from Unity
        float leftRight = Input.GetAxis(horizontalAxis);

        //Create direction vector from axis input
        Vector2 direction = new Vector2(leftRight, 0);

        //Make direction vector length 1
        direction = direction.normalized;

        //calculate velocity
        Vector2 velocity = direction * speed;
        velocity.y = physicsBody.velocity.y;

        //give the velocity to the rigid body
        physicsBody.velocity = velocity;

        //tell animator our speed
        fletcherAnimator.SetFloat("walkSpeed", Mathf.Abs(velocity.x));

        //Jumpuing

        //detect if touching ground
        //Get the LayerMask from Unity using the name of the layer
        LayerMask groundLayerMask = LayerMask.GetMask("Ground");
        //Ask the player's collider if we are touching the LayerMask
        bool touchingGround = playerCollider.IsTouchingLayers(groundLayerMask);

        bool jumpButtonPressed = Input.GetButtonDown(jumpButton);
        if (jumpButtonPressed == true && touchingGround == true)
        {
            //We have pressed jump so we should set 
            //our upward velocity to our jump speed
            velocity.y = jumpSpeed;

            //give the velocity to the rigid body
            physicsBody.velocity = velocity;
        }



        //checks to see if player is in a place where they can super jump
        LayerMask sjLayerMask = LayerMask.GetMask("SuperJump");

        bool touchingSJ = playerCollider.IsTouchingLayers(sjLayerMask);

        if (jumpButtonPressed == true && touchingSJ == true)
        {
            //We have pressed jump so we should set 
            //our upward velocity to our jump speed
            velocity.y = superJump;

            //give the velocity to the rigid body
            physicsBody.velocity = velocity;
        }


        //flips sprite to face right direction
        if (velocity.x < 0)
        {
            playerSprite.flipX = true;
        }
        else
        {
            playerSprite.flipX = false;
        }


        //time travel
        bool ttButtonPressed = Input.GetButtonDown(ttButton);
        if (ttButtonPressed == true && touchingGround == true)
        {
            //plays tt sound
            tt.Play();

            //saves player's score
            scoreObject.SaveScore();

            //Saves Fletcher's current poistion
            PlayerPrefs.SetFloat("xPos", transform.position.x);
            PlayerPrefs.SetFloat("yPos", transform.position.y);

            //Loads opposite scene
            SceneManager.LoadScene(sceneToLoad);



        }




    }

    public void Kill()
    {
        livesObject.LoseLife();
        livesObject.SaveLives();

        //check to see if any lives left
        bool gameOver = livesObject.IsGameOver();

        if (gameOver == true)
        {
            //loads Game Over is no lives left
            SceneManager.LoadScene("GameOver");
        }

        else
        {
            //gets and reloads current level
            Scene currentLevel = SceneManager.GetActiveScene();

            SceneManager.LoadScene(currentLevel.buildIndex);

        }

    }

}
