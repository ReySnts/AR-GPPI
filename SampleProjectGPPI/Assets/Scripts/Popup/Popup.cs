using UnityEngine;
using UnityEngine.UI;

public class Popup : MonoBehaviour
{
    [SerializeField] protected Button buttonClose;

    protected void Awake() => buttonClose.onClick.AddListener(DestroySelf);

    private void DestroySelf() => Destroy(gameObject);

    protected void Destroy() => buttonClose.onClick.RemoveListener(DestroySelf);
}