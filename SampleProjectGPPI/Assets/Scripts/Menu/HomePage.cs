using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HomePage : Page
{
    [SerializeField] private Animator animator;

    [SerializeField] private Button buttonStart;

    protected override void OnEnable()
    {
        animator.Play("ButtonStart");
        buttonStart.onClick.AddListener(Play);
    }

    private void Play() => SceneManager.LoadScene("Play");

    protected override void OnDisable()
    {
        animator.StopPlayback();
        buttonStart.onClick.RemoveListener(Play);
    }
}