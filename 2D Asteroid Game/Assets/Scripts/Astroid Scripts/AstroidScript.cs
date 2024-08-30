using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AstroidScript : MonoBehaviour
{
    //We must create 1 variable that keeps track of the max speed value of a asteroid!
    public float MaxSpeed;

    //We must create 1 variable that allows us to use game physics
    public Rigidbody2D physics;

    //We must create 1 variable that keeps track of the direction
    Vector2 direction;

    //We must create 1 variable that keeps track of the point value of a coin!
    //We must create 1 variable that access the SampleScoreManagerScript !

    public int pointValue;

    //This variable calls on the SampleScoreManagerScript, this will allow you to access all pubic components/properties of this script within your current one!
    public ScoreManager scoreManager;

    private void Awake()
    {
        Vector2 movement = new Vector2(Random.Range(-MaxSpeed, MaxSpeed), Random.Range(-MaxSpeed, MaxSpeed));
        physics.AddForce(movement);
    }

    //Add a OnTriggerEnter() Method, to check for collision
    private void OnTriggerEnter(Collider other)
    {
        //Create a if statement that checks if coin is collides with player
        if (other.gameObject.tag == "Projectile")
        {
            scoreManager.scoreValue += pointValue;
            //Destroy game object and add to the score
            Destroy(other.gameObject);
            Destroy(this.gameObject);
            
        }
    }


}
