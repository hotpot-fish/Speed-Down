using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public List<GameObject> platforms = new List<GameObject>();
    
    public float spawnTime;
    private float countTime;
    // Start is called before the first frame update
    void Start()
    {

    }

    public void SpawnPlatform()
    {
        Vector3 spawnPosition = transform.position;
        spawnPosition.x = Random.Range(-3.0f, 3.0f);
        int index = Random.Range(0, platforms.Count);
        GameObject go = Instantiate(platforms[index], spawnPosition,
       Quaternion.identity);
        go.transform.SetParent(this.gameObject.transform);
    }

    // Update is called once per frame
    void Update()
    {
        countTime += Time.deltaTime;

        if (countTime >= spawnTime)
        {
            SpawnPlatform();
            countTime = 0;
        }
    }
}
