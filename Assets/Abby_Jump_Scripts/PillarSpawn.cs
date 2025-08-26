using UnityEngine;

public class PillarSpawn : MonoBehaviour
{
    // Prefab Reference
    public GameObject Pillars;

    // Parameters
    public float SpawnRate = 3;
    private float timer = 0;
    public float HeightOffset = 6; 

    void Start()
    {   
        // Call Spawn Pillar To Remove First Pillar Spawn Dellay 
        SpawnPillar();
    }

    // Update is called once per frame 
    void Update()
    {
        // Pillar Spawn Intervals
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

    // Pillar Spawning Logic
    void SpawnPillar()
    {
        float LowestPoint = transform.position.y - HeightOffset;
        float HighestPoint = transform.position.y + HeightOffset;

        Instantiate(Pillars, new Vector3 (transform.position.x, Random.Range(LowestPoint, HighestPoint), 0), transform.rotation);
    }
}
