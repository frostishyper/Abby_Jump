using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PillarScroll : MonoBehaviour
{
    public float ScrollSpeed = 4;
    public float DeadZone = -25;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Pillar Scrolling Behavior
        transform.position = transform.position + (Vector3.left * ScrollSpeed) * Time.deltaTime;

        if (transform.position.x < DeadZone)
        {
            Destroy(gameObject);
        }
    }
}
