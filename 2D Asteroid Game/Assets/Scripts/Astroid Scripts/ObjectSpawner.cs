using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject Obsticle;

    public float timer;

    public float repeatRate;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawner",timer,repeatRate);
    }

    public void Spawner()
    {
        Instantiate(Obsticle, this.transform.position, Quaternion.identity);
    }

}
