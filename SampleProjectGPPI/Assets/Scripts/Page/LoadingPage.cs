using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class LoadingPage : Page
{
    [SerializeField] private Page pageToBeLoaded;

    [field: SerializeField] public Slider Slider { get; private set; }

    protected override void Awake() => StartCoroutine(DoLoading());

    private IEnumerator DoLoading()
    {
        while (Slider.value < Slider.maxValue)
        {
            Slider.value += 10f * Time.deltaTime;
            yield return null;
        }
        Destroy(gameObject);
    }

    protected override void OnDestroy() => LoadPage();

    private void LoadPage() => Instantiate(original: pageToBeLoaded, parent: transform.parent);
}