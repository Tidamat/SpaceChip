using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Transform spawnPosition;
    public GameObject template;
    public float spawnInterval;
    public float Interval;

    void Update()
    {
        Interval = Interval + Time.deltaTime;

        if (Interval >= spawnInterval)
        {
            Spawn();
            Interval = Interval - spawnInterval;
        }
    }

    void Spawn()
    {
        //Game.Instance.spawnCount++;
        Instantiate(template, spawnPosition.position, spawnPosition.rotation);
    }


}
