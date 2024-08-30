using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class WeaponScript : MonoBehaviour
{
    //Variables
    public enum WeaponStates { SemiAuto, Auto, Burst}
    public WeaponStates state;

    //Create your own variable for Key Inputs
    private KeyCode ShootButton;
    private int ShootButton2;

    //The gameObject we will be spawning 
    public GameObject projectile;

    private void Awake()
    {
        ShootButton = KeyCode.Space;
        ShootButton2 = 0;
    }

    public void Shooting()
    {
        if (Input.GetKeyDown(ShootButton) || Input.GetMouseButtonDown(ShootButton2))
        {
            SpawnProjectiles(projectile);

        }
    }

    private GameObject SpawnProjectiles(GameObject projectile)
    {
        projectile = Instantiate(projectile, this.transform.position, Quaternion.identity);
        projectile.GetComponent<ProjectileScript>().Init(transform.up);
        
        return projectile;
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

    private void Update()
    {
        Shooting();
    }


}
