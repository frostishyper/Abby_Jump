using UnityEngine;
using UnityEngine.EventSystems;

public class RetryButton : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    // GameObject Components & References
    private Animator animator;
    AudioSource RetrySound;

    void Start()
    {
        // Obtain GameObject Components
        animator = GetComponent<Animator>();
        RetrySound = GetComponent<AudioSource>();
    }

    // Change Animator Parameters (Trigger Hover Animation)
    public void OnPointerEnter(PointerEventData eventData)
    {
        animator.SetBool("Hovered", true);
    }
    // Change Animator Parameters (Return To Idle State)
    public void OnPointerExit(PointerEventData eventData)
    {
        animator.SetBool("Hovered", false);
    }
}
