using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbbyScript : MonoBehaviour
{
    public Rigidbody2D AbbyBody;
    public CoreScript Core;
    public float JumpPower = 6.5f;
    public bool AbbyIsAlive = true;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.name = "Abby";
        Core = GameObject.FindGameObjectWithTag("CoreTag").GetComponent<CoreScript>();
    }

    // Update is called once per frame
    void Update()
    {
        // Jump Behavior
        if (Input.GetKeyDown(KeyCode.Space) == true && AbbyIsAlive)
        {
            AbbyBody.velocity = Vector2.up * JumpPower;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Core.GameOver();
    }
}
