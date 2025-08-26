using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HomeButton : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{   
    // GameObject Components & References
    private Animator animator;
    public AudioSource BtnHomeAudio;
    public AudioClip HomeSound;

    void Start()
    {   
        // Obtain GameObject Components
        animator = GetComponent<Animator>();
        Button btn = GetComponent<Button>();

        // On Click Listener
        btn.onClick.AddListener(GoHome);
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
    private void GoHome()
    {
        BtnHomeAudio.PlayOneShot(HomeSound);
        StartCoroutine(LoadSceneAfterSound());
    }
    // Corutine To Delay Exit To Allow Sound To Play
    private IEnumerator LoadSceneAfterSound()
    {
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene("Menu");
    }
}
