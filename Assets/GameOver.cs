using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public static Text over;
    bool done = false;
    // Start is called before the first frame update
    void Start()
    {
        over = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public static void end()
    {
        over.text = "Game Over";
        Spawner.going = false;
        Spawner.dead = true;
    }

 
}

