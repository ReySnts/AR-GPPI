using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HomeButton : ButtonListener
{
    [SerializeField] private PopupDisplayer popupDisplayer;

    [SerializeField] private Button buttonStart;

    [SerializeField] private Button buttonQuit;

    [SerializeField] private Button buttonAbout;

    public override void AddAll()
    {
        buttonStart.onClick.AddListener(ToPlay);
        buttonQuit.onClick.AddListener(QuitApplication);
        buttonAbout.onClick.AddListener(popupDisplayer.DisplayPopup);
    }

    private void ToPlay() => SceneManager.LoadScene(SceneName.PLAY);

    private void QuitApplication() => Application.Quit();

    public override void RemoveAll()
    {
        buttonStart.onClick.RemoveListener(ToPlay);
        buttonQuit.onClick.RemoveListener(QuitApplication);
        buttonAbout.onClick.RemoveListener(popupDisplayer.DisplayPopup);
    }
}