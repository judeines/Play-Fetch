using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float spawnPeriod = 1.5f;
    private float nextSpawnTime;

    // Update is called once per frame
    void Update()
    {
        


            // On spacebar press, send dog
            if (Input.GetKeyDown(KeyCode.Space) && Time.time > nextSpawnTime )
        {
            nextSpawnTime = Time.time + spawnPeriod;
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        }
    }
}
