using UnityEngine;

public class PillarScroll : MonoBehaviour
{   

    // Parameters
    public float ScrollSpeed = 4;
    public float DeadZone = -25;

    void Update()
    {
        // Pillar Scrolling Logic
        transform.position = transform.position + (Vector3.left * ScrollSpeed) * Time.deltaTime;
        // Destroy Pillar After They Move Past The Camera
        if (transform.position.x < DeadZone)
        {
            Destroy(gameObject);
        }
    }
}
