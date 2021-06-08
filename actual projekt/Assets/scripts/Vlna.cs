using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Vlna : MonoBehaviour
{
    Text wave;
    private int cislo;
    private void Start()
    {
        wave = GetComponent<Text>();
    }
    private void Update()
    {
        cislo = Spawner.cisloWavy;
        
        wave.text = "Vlna: " +cislo.ToString();
    }
}
