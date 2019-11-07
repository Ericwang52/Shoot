using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cashmuny : MonoBehaviour
{
    public static int cash = 0;
    Text cashText;
    // Start is called before the first frame update
    void Start()
    {
        cashText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        cashText.text = "Cash: " + cash;
    }
}
