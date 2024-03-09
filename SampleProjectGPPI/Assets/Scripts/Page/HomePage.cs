using UnityEngine;

public class HomePage : Page
{
    [SerializeField] private Animator animator;

    protected override void Awake()
    {
        buttonListener.AddAll();
        animator.Play(AnimationState.BUTTON_START);
    }

    protected override void OnDestroy()
    {
        animator.StopPlayback();
        buttonListener.RemoveAll();
    }
}