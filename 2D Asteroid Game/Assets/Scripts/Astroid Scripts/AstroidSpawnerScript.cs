using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AstroidSpawnerScript : MonoBehaviour
{
    
    public GameObject AstroidObject;
    public float timer;
    public float repeatRate;
    // Start is called before the first frame update
    void Awake()
    {
        InvokeRepeating("Spawner",timer,repeatRate);
    }

    void Spawner()
    {
        Instantiate(AstroidObject, this.transform.position, Quaternion.identity);
    }
}
