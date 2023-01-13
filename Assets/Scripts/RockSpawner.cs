using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockSpawner : MonoBehaviour
{
    public GameObject rock;
    public float frequency = 1;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRocks", 1, frequency);
    }

    void SpawnRocks()
    {
        Vector3 randomPos = new Vector3(transform.position.x, Random.Range(-2, 2), transform.position.z);
        Instantiate(rock, randomPos, transform.rotation);
    }
}
