using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CodeMonkey.Utils;
using CodeMonkey;


public class Spawner : MonoBehaviour
{
    public static int zivoty = 100;
    public static int penize = 900;
    public GameObject Dinosaurus_basic;
    public Transform SpawnPoint;
    private int counter;

    
    void Update()
    {
       counter++;
       if(counter >= 500)
       {
           Instantiate(Dinosaurus_basic, SpawnPoint.position, SpawnPoint.rotation);
           counter = 0;
       }
    }
    private void Spawn(){
       

    
    }
    

}
