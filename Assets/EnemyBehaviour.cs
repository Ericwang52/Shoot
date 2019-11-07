using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    public float fallSpeed = 0.8f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Spawner.going)
        {
            transform.Translate(Vector2.down * fallSpeed * Time.deltaTime / 100, Space.World);
        }
        else if(Spawner.dead)
        {
            Destroy(gameObject);
        }
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "bullet")
        {
            Score.score++;
            Cashmuny.cash += 5;
            Destroy(gameObject);
        }
    }
}
