using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class end : MonoBehaviour
{

    public GameObject button;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.name = "end";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        button.SetActive(true);

        GameOver.end();
     
    }
}
