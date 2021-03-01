using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    
    public GameObject hazard;

    void Start()
    {
        Instantiate(hazard, transform.position, Quaternion.identity);
    }
}
