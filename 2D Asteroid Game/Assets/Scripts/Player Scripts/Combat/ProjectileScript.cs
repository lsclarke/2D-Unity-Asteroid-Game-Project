using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileScript : MonoBehaviour
{
    [Range(0,10)]
    public float speed;
    public Rigidbody2D physics;

    private Vector2 startPosition;
    public float maxDistance;
    private float conquaredDistance = 0;

    public LayerMask Astroid;
   


    public void Init(Vector2 direction)
    {
        startPosition = transform.position;
        physics.velocity = direction * speed;
    }

    private void Update()
    {
        conquaredDistance = Vector2.Distance(transform.position, startPosition);
        if (conquaredDistance >= maxDistance)
        {
            print("Disable Object");
        }
    }
}
