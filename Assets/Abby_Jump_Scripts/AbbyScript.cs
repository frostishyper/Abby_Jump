using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbbyScript : MonoBehaviour
{
    public Rigidbody2D AbbyBody;
    public float JumpPower = 6;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.name = "Abby";
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true)
        {
            AbbyBody.velocity = Vector2.up * JumpPower; 
        }
    }
}
