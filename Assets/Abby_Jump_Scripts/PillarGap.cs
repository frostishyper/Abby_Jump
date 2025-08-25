using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PillarGap : MonoBehaviour
{
    public CoreScript  Core;
    // Start is called before the first frame update
    void Start()
    {
        Core = GameObject.FindGameObjectWithTag("CoreTag").GetComponent<CoreScript>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 10)
        {
            Core.AddScore(1);
        }
    }
}
