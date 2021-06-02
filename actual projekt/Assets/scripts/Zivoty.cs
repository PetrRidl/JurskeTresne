using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Zivoty : MonoBehaviour
{
    private int counter;    
    Text zivoty;

    private void Start()
    {
        zivoty = GetComponent<Text>();
    }
    private void Update()
    {
        counter++;
        if(counter >= 50)
        {
            zivoty.text = Spawner.zivoty.ToString();
            counter = 0;
        }
        
    }
}
