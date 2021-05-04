using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Zivoty : MonoBehaviour
{
    
    Text zivoty;

    private void Start()
    {
        zivoty = GetComponent<Text>();
    }
    private void Update()
    {
        zivoty.text = "Životy: " + Spawner.zivoty.ToString();
    }
}
