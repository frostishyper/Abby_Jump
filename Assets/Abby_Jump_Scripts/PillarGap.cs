using UnityEngine;

public class PillarGap : MonoBehaviour
{
    // Outide Reference
    public CoreScript Core;
    void Start()
    {
        // Get External Reference Via Its Tag
        Core = GameObject.FindGameObjectWithTag("CoreTag").GetComponent<CoreScript>();
    }

    // Collision Check To Add Score (Calls Method From CoreScript.cs)
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 10)
        {
            Core.AddScore(1);
        }
    }
}
