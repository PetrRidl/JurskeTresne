using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CodeMonkey.Utils;
using CodeMonkey;


public class Spawner : MonoBehaviour
{
    public static int zivoty = 100;
    public static int penize = 1000;
    public GameObject Dinosaurus_basic;
    public Transform SpawnPoint;
    public GameObject Vitezstvi;
    public Transform spawn_Konec;
    private int counter;
    private int wave = 1;
    private int spawn;
   

    
    void Update()
    {
     
      

    }
    public void Spawn(){
       if(wave == 1)
       {
           StartCoroutine(wave1());
           wave++;
       }
        else if(wave == 2)
       {
           StartCoroutine(wave2());
           wave++;
       }
        else  if(wave == 3)
       {
           StartCoroutine(wave3());
           wave++;
       }
        else if(wave == 4)
       {
           StartCoroutine(wave4());
           wave++;
       }
        else if(wave == 5)
       {
           StartCoroutine(wave5());
           wave++;
       }
        else  if(wave == 6)
       {
           StartCoroutine(wave6());
           wave++;
       }
        else if(wave == 7)
       {
           StartCoroutine(wave7());
           wave++;
       }
        else if(wave == 8)
       {
           StartCoroutine(wave8());
           wave++;
       }
        else if(wave == 9)
       {
           StartCoroutine(wave9());
           wave++;
       }
        else if(wave == 10)
       {
           StartCoroutine(wave10());
           wave++;
       }
        else if(wave == 11)
       {
           StartCoroutine(wave11());
           wave++;
       }
        else if(wave == 12)
       {
           StartCoroutine(wave12());
           wave++;
       }    
        else if(wave == 13)
       {
           StartCoroutine(wave13());
           wave++;
       }
        else if(wave == 14)
       {
           StartCoroutine(wave14());
           wave++;
       } 
       else  if(wave == 15)
       {
           StartCoroutine(wave15());
           wave++;
       }
        else if(wave == 16)
       {
           StartCoroutine(wave16());
           wave++;
       } 
        else if(wave == 17)
       {
           StartCoroutine(wave17());
           wave++;
       }     
        else if(wave == 18)
       {
           StartCoroutine(wave18());
           wave++;
       }   
       else  if(wave == 19)
       {
           StartCoroutine(wave19());
           wave++;
       } 
        else if(wave == 20)
       {
           StartCoroutine(wave20());
           
       }  
       else if(wave == 21)
       {
           Instantiate(Vitezstvi, spawn_Konec.position, spawn_Konec.rotation);
       }
    
                    
    }
    IEnumerator wave1()
    {
        for(int i = 0; i < wave; i++)
        {
            Instantiate(Dinosaurus_basic, SpawnPoint.position, SpawnPoint.rotation);
            yield return new WaitForSeconds(0.5f);
        }
        
    }
    IEnumerator wave2()
    {
        for(int i = 0; i < wave; i++)
        {
            Instantiate(Dinosaurus_basic, SpawnPoint.position, SpawnPoint.rotation);
            yield return new WaitForSeconds(0.5f);
        }
    }
    IEnumerator wave3()
    {
        for(int i = 0; i < wave; i++)
        {

            Instantiate(Dinosaurus_basic, SpawnPoint.position, SpawnPoint.rotation);
            yield return new WaitForSeconds(0.5f);
        }
    }
    IEnumerator wave4()
    {
      for(int i = 0; i < wave; i++)
        {

            Instantiate(Dinosaurus_basic, SpawnPoint.position, SpawnPoint.rotation);
            yield return new WaitForSeconds(0.5f);
        }
    }
    IEnumerator wave5()
    {
        for(int i = 0; i < wave; i++)
        {

            Instantiate(Dinosaurus_basic, SpawnPoint.position, SpawnPoint.rotation);
            yield return new WaitForSeconds(0.5f);
        }
    }
    IEnumerator wave6()
    {
        for(int i = 0; i < wave; i++)
        {
            Instantiate(Dinosaurus_basic, SpawnPoint.position, SpawnPoint.rotation);
            yield return new WaitForSeconds(0.5f);
        }
    }
    IEnumerator wave7()
    {
        for(int i = 0; i < wave; i++)
        {
            Instantiate(Dinosaurus_basic, SpawnPoint.position, SpawnPoint.rotation);
            yield return new WaitForSeconds(0.5f);
        }
    }
    IEnumerator wave8()
    {
        for(int i = 0; i < wave; i++)
        {
            Instantiate(Dinosaurus_basic, SpawnPoint.position, SpawnPoint.rotation);
            yield return new WaitForSeconds(0.5f);
        }
    }
    IEnumerator wave9()
    {
        for(int i = 0; i < wave; i++)
        {
            Instantiate(Dinosaurus_basic, SpawnPoint.position, SpawnPoint.rotation);
            yield return new WaitForSeconds(0.5f);
        }
    }
    IEnumerator wave10()
    {
        for(int i = 0; i < wave; i++)
        {
            Instantiate(Dinosaurus_basic, SpawnPoint.position, SpawnPoint.rotation);
            yield return new WaitForSeconds(0.5f);
        }
    }
    IEnumerator wave11()
    {
        for(int i = 0; i < wave; i++)
        {
            Instantiate(Dinosaurus_basic, SpawnPoint.position, SpawnPoint.rotation);
            yield return new WaitForSeconds(0.5f);
        }
    }
    IEnumerator wave12()
    {
        for(int i = 0; i < wave; i++)
        {
            Instantiate(Dinosaurus_basic, SpawnPoint.position, SpawnPoint.rotation);
            yield return new WaitForSeconds(0.5f);
        }
    }
    IEnumerator wave13()
    {
        for(int i = 0; i < wave; i++)
        {
            Instantiate(Dinosaurus_basic, SpawnPoint.position, SpawnPoint.rotation);
            yield return new WaitForSeconds(0.5f);
        }
    }
    IEnumerator wave14()
    {
        for(int i = 0; i < wave; i++)
        {
            Instantiate(Dinosaurus_basic, SpawnPoint.position, SpawnPoint.rotation);
            yield return new WaitForSeconds(0.5f);
        }
    }
    IEnumerator wave15()
    {
        for(int i = 0; i < wave; i++)
        {
            Instantiate(Dinosaurus_basic, SpawnPoint.position, SpawnPoint.rotation);
            yield return new WaitForSeconds(0.5f);
        }
    }
    IEnumerator wave16()
    {
        for(int i = 0; i < wave; i++)
        {
            Instantiate(Dinosaurus_basic, SpawnPoint.position, SpawnPoint.rotation);
            yield return new WaitForSeconds(0.5f);
        }
    }
    IEnumerator wave17()
    {
        for(int i = 0; i < wave; i++)
        {
            Instantiate(Dinosaurus_basic, SpawnPoint.position, SpawnPoint.rotation);
            yield return new WaitForSeconds(0.5f);
        }
    }
    IEnumerator wave18()
    {
        for(int i = 0; i < wave; i++)
        {
            Instantiate(Dinosaurus_basic, SpawnPoint.position, SpawnPoint.rotation);
            yield return new WaitForSeconds(0.5f);
        }
    }
    IEnumerator wave19()
    {
        for(int i = 0; i < wave; i++)
        {
            Instantiate(Dinosaurus_basic, SpawnPoint.position, SpawnPoint.rotation);
            yield return new WaitForSeconds(0.5f);
        }
    }
    IEnumerator wave20()
    {
        for(int i = 0; i < wave; i++)
        {
            Instantiate(Dinosaurus_basic, SpawnPoint.position, SpawnPoint.rotation);
            yield return new WaitForSeconds(0.5f);
        }
    }


    

}
