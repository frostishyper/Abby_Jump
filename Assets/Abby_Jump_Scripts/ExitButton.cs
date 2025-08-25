using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ExitButton : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();

        // Quit Game On Click
        Button btn = GetComponent<Button>();
        btn.onClick.AddListener(QuitGame);
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        animator.SetBool("Hovered", true);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        animator.SetBool("Hovered", false);
    }
    
    private void QuitGame()
    {
        Application.Quit();
    }
}
