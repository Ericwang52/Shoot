using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttonner : MonoBehaviour
{
    public GameObject continueButton;
    void Start()
    {
        continueButton.SetActive(false);
    }

    public void activate()
    {
        continueButton.SetActive(true);

    }
    public void restart()
    {
        GameOver.over.text = "";
        continueButton.SetActive(false);
        Score.score = 0;
        Spawner.going = true;
        Spawner.dead = false;
    }
}
