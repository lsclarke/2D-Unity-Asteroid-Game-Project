using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthScript : MonoBehaviour
{
    //This variable is for our health value
    public float Health;
    //This method checks the moment the player has touched another collider
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Asteroid")
        {
            //Call on take damage method
            TakeDamage(5);
            //Prints we took damage
            print("We Took Damage!");
        }
    }

    //Custom method that helps to regulate how much damage we take 
    public float TakeDamage(int damage)
    {
        Health -= damage;
        return Health;
    }
}
