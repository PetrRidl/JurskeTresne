using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Odminuti : MonoBehaviour
{
    private int counter;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        counter++;
        if(counter >= 200)Destroy(gameObject);
    }
}
