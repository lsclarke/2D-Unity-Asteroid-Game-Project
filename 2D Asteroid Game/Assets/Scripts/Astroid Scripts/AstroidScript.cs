using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AstroidScript : MonoBehaviour
{
    
    public float MaxSpeed;
    public Rigidbody2D physics;
    Vector2 direction;
    public ParticleSystem ParticleSystem;


    private void Awake()
    {
        Vector2 movement = new Vector2 (Random.Range(-MaxSpeed,MaxSpeed), Random.Range(-MaxSpeed,MaxSpeed));
        physics.AddForce (movement);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Projectile")
        {
            Instantiate(ParticleSystem, this.transform.position, Quaternion.identity);
            Destroy(other.gameObject);
        }
    }

}
