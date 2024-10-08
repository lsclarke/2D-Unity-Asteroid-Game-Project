using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ProjectileScript : MonoBehaviour
{
    [Range(0,10)]
    public float speed;
    public Rigidbody2D physics;

    private Vector2 startPosition;
    public float maxDistance;
    private float conquaredDistance = 0;

    public LayerMask Astroid;

    //This variable calls on the SampleScoreManagerScript, this will allow you to access all pubic components/properties of this script within your current one!
    public ScoreManager scoreManager;

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

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Asteroid")
        {
            Destroy(other.gameObject);
            Destroy(this.gameObject);
            scoreManager.scoreValue += 2;
            scoreManager.scoreText.text = "Score: " + scoreManager.scoreValue;
        }
    }
}
