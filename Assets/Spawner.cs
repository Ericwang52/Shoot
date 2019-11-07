using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject enemy;
    Vector2 spawnLocation;
    public float spawnRate;
    float timeToNextSpawn = 0.0f;
    int level = 0;
    public static bool going = true;
    public static bool dead = false;
    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {

        if (Time.time > timeToNextSpawn && going==true)
        {
            timeToNextSpawn = Time.time + spawnRate;
            level++;
            if (level % 20 == 0)
            {
                spawnRate = spawnRate * 0.9f;
            }
            spawnLocation = new Vector2(Random.Range(-2.5f, 2.5f), transform.position.y);
            Instantiate(enemy, spawnLocation, Quaternion.identity);
        }

    }
}
