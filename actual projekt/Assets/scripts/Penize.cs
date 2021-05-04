using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Penize : MonoBehaviour
{
    
    Text penize;

    private void Start()
    {
        penize = GetComponent<Text>();
    }
    private void Update()
    {
        penize.text = "Peníze: " + Spawner.penize.ToString();
    }
}
