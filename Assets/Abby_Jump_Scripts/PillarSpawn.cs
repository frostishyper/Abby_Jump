using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PillarSpawn : MonoBehaviour
{
    public GameObject Pillars;
    public float SpawnRate = 2;
    private float timer = 0;

    // Start is called before the first frame update
    void Start()
    {
        SpawnPillar();
    }

    // Update is called once per frame 
    void Update()
    {
        if (timer < SpawnRate)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            SpawnPillar();
            timer = 0;
        }

    }

    void SpawnPillar()
    {
        Instantiate(Pillars, transform.position, transform.rotation);
    }
}
