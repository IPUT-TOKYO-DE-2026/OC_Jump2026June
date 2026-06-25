using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject prefab;
    public float startDelay = 2;
    public float repeatRate = 2;
    private Vector3 spawnPosition = new Vector3(25, 0, 0);

    // Start is called before the first frame update
    void Start()
    {
        if (prefab != null)
        {
            InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
        }
    }

    void SpawnObstacle()
    {
        if (GameManager.isGameOver() == false)
        {
            Instantiate(prefab, spawnPosition, prefab.transform.rotation);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
