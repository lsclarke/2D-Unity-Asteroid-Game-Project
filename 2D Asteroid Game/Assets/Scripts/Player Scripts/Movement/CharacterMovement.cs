using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    //OOP variables
    private CharacterScript Ship;
    //Variables for movement
    private float speed;
    public float normalSpeed, thrusterSpeed;
    private float InputHorizontal, InputVertical;
    public Rigidbody2D physics;
    private Vector2 thrustForce;

    private Vector3 mousePosition;
    private Vector3 direction;

    private void Awake()
    {
        Ship = this.GetComponent<CharacterScript>();

        Ship.setSpeed(normalSpeed);
        speed = Ship.getSpeed();
    }

    private void Update()
    {
        Movement();
        Rotation();
    }

    private void Rotation()
    {
        //set variable to be mouse input
        mousePosition = Input.mousePosition;

        //mouse position is equal to the point of the mouse position within the camera view
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

        //direction is equal to the point x of the mouse position and point y
        direction = new Vector2(mousePosition.x - transform.position.x, mousePosition.y - transform.position.y);

        //Set the transform direction to equal the direction variable
        transform.up = direction;
    }

    private void Movement()
    {
        InputHorizontal = Input.GetAxis("Horizontal");
        InputVertical = Input.GetAxis("Vertical");

        physics.velocity = new Vector2(InputHorizontal * speed, InputVertical * speed);
    }
}
