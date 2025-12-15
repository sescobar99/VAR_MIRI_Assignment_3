using UnityEngine;

public class SimpleRandomSpawner : MonoBehaviour
{
    public GameObject[] prefabs;

    public void Spawn()
    {
        int i = Random.Range(0, prefabs.Length);
        Instantiate(prefabs[i], new Vector3(0f, 1f, 0f), Quaternion.identity);
    }
}