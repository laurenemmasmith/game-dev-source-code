using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] hazardSets;

    private float spawnGap;
    public float startSpawnGap;
    public float decreaseTime;
    public float minTime = 1.5f;

    private void Update()
    {
        if (spawnGap <= 0){
            int rand = Random.Range(0, hazardSets.Length);
            Instantiate(hazardSets[rand], transform.position, Quaternion.identity);
            spawnGap = startSpawnGap;
            if (startSpawnGap > minTime){
                startSpawnGap -= decreaseTime;
            }
        }else{
            spawnGap -= Time.deltaTime;
        }
    }
}
