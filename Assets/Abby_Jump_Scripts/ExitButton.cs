using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ExitButton : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    // GameObject Components & References
    private Animator animator;
    AudioSource ExitSound;

    void Start()
    {
        // Obtain GameObject Components
        animator = GetComponent<Animator>();
        ExitSound = GetComponent<AudioSource>();
        Button btn = GetComponent<Button>();

        // On Click Listener
        btn.onClick.AddListener(QuitGame);
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

    // On Click Effect
    private void QuitGame()
    {
        ExitSound.Play();
        StartCoroutine(ExitAfterSound());
    }
    // Corutine To Delay Exit To Allow Sound To Play
    private IEnumerator ExitAfterSound()
    {
        yield return new WaitForSeconds(1f);
        Application.Quit();
    }
}
