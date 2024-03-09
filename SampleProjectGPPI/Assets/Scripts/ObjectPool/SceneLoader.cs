using System.Threading.Tasks;
using UnityEngine;

public class SceneLoader : ObjectPool
{
    [SerializeField] private LoadingPage loadingPage;

    private void DisactivateAll()
    {
        var allChildTransforms = GetComponentsInChildren<Transform>();
        foreach (var eachTransform in allChildTransforms)
        {
            var eachGameObject = eachTransform.gameObject;
            Pool(eachGameObject);
        }
    }

    private async void Start()
    {
        DisactivateAll();
        Get();
        await ActivateAll();
    }

    private async Task ActivateAll()
    {
        while (queue.Count > 0)
        {
            var spawnDuration = queue.Count * 5000f * Time.deltaTime / loadingPage.Slider.maxValue;
            await Task.Delay(millisecondsDelay: (int)spawnDuration);
            Get();
        }
    }
}