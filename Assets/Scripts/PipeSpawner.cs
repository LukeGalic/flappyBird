using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject pipe;
    public float spawnTime;
    public float startingX;
    public float minY;
    public float maxY;

    // Start is called before the first frame update
    void Start()
    {
        SpawnPipe();
    }

    void SpawnPipe()
    {
        GameObject.Instantiate(
        pipe, new Vector3(startingX, Random.Range(minY, maxY), 0), Quaternion.identity);
        Invoke("SpawnPipe", spawnTime);
    }

}
