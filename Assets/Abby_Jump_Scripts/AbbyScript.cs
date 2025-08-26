using UnityEngine;

public class AbbyScript : MonoBehaviour
{

    // GameObject Components & References
    public Rigidbody2D AbbyBody;
    private Animator animator;
    public AudioSource AbbyAudio;
    public AudioClip AbbyJump;
    public AudioClip AbbyDies;

    // Referencing Outside Script
    public CoreScript Core;

    // Status And Parameters
    public bool AbbyIsAlive = true;
    public float JumpPower = 6.5f;

    // Start is called before the first frame update
    void Start()
    {   
        // Hehe
        gameObject.name = "Abby";
        // Obtain GameObject Components
        animator = GetComponent<Animator>();
        // Get External Reference Via Its Tag
        Core = GameObject.FindGameObjectWithTag("CoreTag").GetComponent<CoreScript>();
    }

    void Update()
    {
        Jumping();
    }

    // Jumping Logic
    // Only Allows Jumping if Abby Is Alive
    // Play Sound On Jump
    void Jumping()
    {
        if (Input.GetKeyDown(KeyCode.Space) && AbbyIsAlive)
        {
            AbbyBody.velocity = Vector2.up * JumpPower;
            animator.SetTrigger("Jump");
            AbbyAudio.PlayOneShot(AbbyJump);

        }
    }

    // When Hitting A Pillar
    // Triggers Gameover & Changes Abby's Status
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Core.GameOver();
        animator.SetBool("Dead", true);
        AbbyAudio.PlayOneShot(AbbyDies);
        AbbyIsAlive = false;
    }
}
