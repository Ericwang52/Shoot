using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public float bulletSpeed;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.name = "bullet";

    }

    // Update is called once per frame
    void Update()
    {
 
        if (Spawner.going)
        {
            transform.position += transform.forward * bulletSpeed * Time.deltaTime;
        }
        else if(Spawner.dead)
        {
            Destroy(gameObject);
        }
    }
    void OnBecameInvisible()
    {
        Destroy(gameObject);

    }
    void OnCollisionEnter2D(Collision2D col)
    {
        Destroy(gameObject);
    }
}

