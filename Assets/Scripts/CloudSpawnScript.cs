using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudSpawnScript : MonoBehaviour
{
    public GameObject cloud;
    public float spawnRate = 2;
    private float spawnTime = 0;
    public float heightOffset = 15;

    void Start()
    {
        spawnCloud();
    }

    void Update()
    {
        if (spawnTime < spawnRate)
        {
            spawnTime += Time.deltaTime;
        }
        else
        {
            spawnCloud();
            spawnTime = 0;
        }
    }

    void spawnCloud()
    {

        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;

        Instantiate(cloud, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);
    }
}
