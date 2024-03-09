using UnityEngine;

public class PopupDisplayer : MonoBehaviour
{
    [SerializeField] private Popup popupToBeDisplayed;

    private void CreatePopup() => Instantiate(original: popupToBeDisplayed, parent: transform);

    public void DisplayPopup() => CreatePopup();
}