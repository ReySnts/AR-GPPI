using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayButton : ButtonListener
{
    [SerializeField] private Button buttonHome;

    public override void AddAll() => buttonHome.onClick.AddListener(ToMenu);

    private void ToMenu() => SceneManager.LoadScene(SceneName.MENU);

    public override void RemoveAll() => buttonHome.onClick.RemoveListener(ToMenu);
}