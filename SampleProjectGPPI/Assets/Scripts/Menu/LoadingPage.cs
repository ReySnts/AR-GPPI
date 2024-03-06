using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class LoadingPage : Page
{
    [SerializeField] private Page pageToBeLoaded;

    [SerializeField] private Slider slider;

    protected override void OnEnable()
    {
        pageToBeLoaded?.gameObject.SetActive(false);
        StartCoroutine(Loading());
    }

    private IEnumerator Loading()
    {
        while (slider.value < slider.maxValue)
        {
            slider.value += 10f * Time.deltaTime;
            yield return null;
        }
        gameObject.SetActive(false);
    }

    protected override void OnDisable() => pageToBeLoaded?.gameObject.SetActive(true);
}