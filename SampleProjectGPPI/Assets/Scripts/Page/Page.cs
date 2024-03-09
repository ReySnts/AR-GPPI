using UnityEngine;

public abstract class Page : MonoBehaviour
{
    [SerializeField] protected ButtonListener buttonListener;

    protected abstract void Awake();

    protected abstract void OnDestroy();
}