using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    protected readonly Queue<GameObject> queue = new();

    protected void Pool(GameObject eachGameObject)
    {
        eachGameObject.SetActive(false);
        queue.Enqueue(eachGameObject);
    }

    protected void Get() => queue.Dequeue().SetActive(true);
}