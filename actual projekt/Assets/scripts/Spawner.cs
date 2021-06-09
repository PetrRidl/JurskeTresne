using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CodeMonkey.Utils;
using CodeMonkey;
using UnityEngine.SceneManagement;


public class Spawner : MonoBehaviour
{
    public static int zivoty = 100;
    public static int penize = 1000;
    public GameObject Dinosaurus_basic;
    public GameObject Dinosaurus_fast;
    public GameObject Dinosaurus_strong;
    public GameObject Dinosaurus_tank;
    public GameObject Vyhra;
    public GameObject Prohra;
    public int level;
    public GameObject Odmitnuti;
    
    
    public Transform SpawnPoint;
    
    public Transform spawn_Konec;
    private int counter;
    public static int wave = 1;
    public static int cisloWavy = 1;
    private int spawn;
    public static int killed;
    public int difficulty;
    private int toKill;
    private bool konec = false;
    private bool start = false;
    private bool spusteno = false;
    private bool auto = false;
    private bool levelbool = false;
    public static bool doubleS = false;
    private float waitToSpawn = 0.5f;
    private float basicWaitToSpawn;
    private bool zrychleno = false;
   

    void Start()
    {
        basicWaitToSpawn = waitToSpawn;
        konec = false;
        auto = false;
        doubleS = false;
        switch (difficulty)
        {
            case 1:
            toKill = 701;
            break;

            case 2:
            toKill = 1190;
            break;

            case 3:
            toKill = 1709;
            break;
        }
        print(level);
        
    }
    
    void Update()
    {   
        if(auto == true && spusteno == false)Spawn();

        
        if(killed == toKill && zivoty > 0 && konec == false)
        {
            Instantiate(Vyhra, spawn_Konec.position, spawn_Konec.rotation);
            if(level >= skript.LevelFinished)skript.nejvyssiDosazeny = level + 1;
            konec = true;
        }
        if(zivoty <= 0 && konec == false)
        {
            Instantiate(Prohra, spawn_Konec.position, spawn_Konec.rotation);
            konec = true;
        }
        if(zivoty < 0) zivoty = 0;
        if(doubleS == true && zrychleno == false)
        {
            zrychleno = true;
            waitToSpawn = waitToSpawn/2;
        }
        if(doubleS == false && zrychleno == true)
        {
            zrychleno = false;
            waitToSpawn = basicWaitToSpawn;
        }
      

    }
    public void Spawn(){
       if(spusteno == false && konec == false){ switch (wave)
        {
            case 1:
            StartCoroutine(wave1());
            
            break;

            case 2:
            StartCoroutine(wave2());
            
            break;

            case 3:
            StartCoroutine(wave3());
            
            break;

            case 4:
            StartCoroutine(wave4());
            
            break;

            case 5:
            StartCoroutine(wave5());
            
            break;

            case 6:
            StartCoroutine(wave6());
            
            break;

            case 7:
            StartCoroutine(wave7());
            
            break;

            case 8:
            StartCoroutine(wave8());
            
            break;

            case 9:
            StartCoroutine(wave9());
            
            break;

            case 10:
            StartCoroutine(wave10());
            
            break;

            case 11:
            StartCoroutine(wave11());
            
            break;

            case 12:
            StartCoroutine(wave12());
            
            break;

            case 13:
            StartCoroutine(wave13());
            
            break;

            case 14:
            StartCoroutine(wave14());
            
            break;

            case 15:
            StartCoroutine(wave15());
            
            break;

            case 16:
            StartCoroutine(wave16());
            
            break;

            case 17:
            StartCoroutine(wave17());
           
            break;

            case 18:
            StartCoroutine(wave18());
           
            break;

            case 19:
            StartCoroutine(wave19());
           
            break;

            case 20:
            StartCoroutine(wave20());
            
            break;

            case 21:
            StartCoroutine(wave21());
            
            break;

            case 22:
            StartCoroutine(wave22());
            
            break;

            case 23:
            StartCoroutine(wave23());
            
            break;

            case 24:
            StartCoroutine(wave24());
            
            break;

            case 25:
            StartCoroutine(wave25());
            
            break;

            case 26:
            StartCoroutine(wave26());
           
            break;

            case 27:
            StartCoroutine(wave27());
            
            break;

            case 28:
            StartCoroutine(wave28());
            
            break;

            case 29:
            StartCoroutine(wave29());
            
            break;

            case 30:
            StartCoroutine(wave30());
            
            break;
        }
        
    
        }
        else if(konec == false)Instantiate(Odmitnuti, spawn_Konec.position, spawn_Konec.rotation);
     
                    
    }
    IEnumerator wave1()
    {
        cisloWavy = 1;
        spusteno = true;
        for(int i = 0; i < 4; i++)
        {
            Instantiate(Dinosaurus_basic, SpawnPoint.position, SpawnPoint.rotation);
            yield return new WaitForSeconds(waitToSpawn);
        }
        spusteno = false;
        wave++;
        
        
    }
    IEnumerator wave2()
    {
        cisloWavy++;
        spusteno = true;
        for(int i = 0; i < 6; i++)
        {
            Instantiate(Dinosaurus_basic, SpawnPoint.position, SpawnPoint.rotation);
            yield return new WaitForSeconds(waitToSpawn);
        }
        spusteno = false;
        wave++;
    }
    IEnumerator wave3()
    {
        cisloWavy++;
        spusteno = true;
        for(int i = 0; i < 9; i++)
        {

            Instantiate(Dinosaurus_basic, SpawnPoint.position, SpawnPoint.rotation);
            yield return new WaitForSeconds(waitToSpawn);
        }
        Instantiate(Dinosaurus_strong, SpawnPoint.position, SpawnPoint.rotation);
        spusteno = false;
        wave++;
    }
    IEnumerator wave4()
    {
        cisloWavy++;
        spusteno = true;
      for(int i = 0; i < 5; i++)
        {

            Instantiate(Dinosaurus_strong, SpawnPoint.position, SpawnPoint.rotation);
            yield return new WaitForSeconds(waitToSpawn);
        }
        spusteno = false;
        wave++;
    }
    IEnumerator wave5()
    {
        cisloWavy++;
        spusteno = true;
        for(int i = 0; i < 7; i++)
        {

            Instantiate(Dinosaurus_strong, SpawnPoint.position, SpawnPoint.rotation);
            yield return new WaitForSeconds(waitToSpawn);
        }
        spusteno = false;
        wave++;
    }
    IEnumerator wave6()
    {
        cisloWavy++;
        spusteno = true;
        for(int i = 0; i < 9; i++)
        {
            Instantiate(Dinosaurus_strong, SpawnPoint.position, SpawnPoint.rotation);
            yield return new WaitForSeconds(waitToSpawn);
        }
        spusteno = false;
        wave++;
    }
    IEnumerator wave7()
    {
        cisloWavy++;
        spusteno = true;
        for(int i = 0; i < 5; i++)
        {
            Instantiate(Dinosaurus_strong, SpawnPoint.position, SpawnPoint.rotation);
            yield return new WaitForSeconds(waitToSpawn);
            Instantiate(Dinosaurus_fast, SpawnPoint.position, SpawnPoint.rotation);
            yield return new WaitForSeconds(waitToSpawn);
            Instantiate(Dinosaurus_strong, SpawnPoint.position, SpawnPoint.rotation);
            yield return new WaitForSeconds(waitToSpawn);
        }
        spusteno = false;
        wave++;
    }
    IEnumerator wave8()
    {
        cisloWavy++;
        spusteno = true;
        for(int i = 0; i < 10; i++)
        {
            Instantiate(Dinosaurus_basic, SpawnPoint.position, SpawnPoint.rotation);
            yield return new WaitForSeconds(waitToSpawn);
            Instantiate(Dinosaurus_fast, SpawnPoint.position, SpawnPoint.rotation);
            yield return new WaitForSeconds(waitToSpawn);
        }
        spusteno = false;
        wave++;
    }
    IEnumerator wave9()
    {
        cisloWavy++;
        spusteno = true;
        for(int i = 0; i < 10; i++)
        {
            Instantiate(Dinosaurus_tank, SpawnPoint.position, SpawnPoint.rotation);
            yield return new WaitForSeconds(waitToSpawn);
            Instantiate(Dinosaurus_fast, SpawnPoint.position, SpawnPoint.rotation);
            yield return new WaitForSeconds(waitToSpawn);
        }
        spusteno = false;
        wave++;
    }
    IEnumerator wave10()
    {
    cisloWavy++;
        spusteno = true;
        for(int i = 0; i < 10; i++)
        {
            Instantiate(Dinosaurus_basic, SpawnPoint.position, SpawnPoint.rotation);
            yield return new WaitForSeconds(waitToSpawn);
            Instantiate(Dinosaurus_strong, SpawnPoint.position, SpawnPoint.rotation);
            yield return new WaitForSeconds(waitToSpawn);
            Instantiate(Dinosaurus_tank, SpawnPoint.position, SpawnPoint.rotation);
            yield return new WaitForSeconds(waitToSpawn);
            Instantiate(Dinosaurus_fast, SpawnPoint.position, SpawnPoint.rotation);
            yield return new WaitForSeconds(waitToSpawn);
        }
        spusteno = false;
        wave++;
    }
    IEnumerator wave11()
    {
        cisloWavy++;
        spusteno = true;
        for(int i = 0; i < 50; i++)
        {
            Instantiate(Dinosaurus_basic, SpawnPoint.position, SpawnPoint.rotation);
            yield return new WaitForSeconds(waitToSpawn);

        }
        for(int i = 0; i < 20; i++)
        {
            Instantiate(Dinosaurus_fast, SpawnPoint.position, SpawnPoint.rotation);
            yield return new WaitForSeconds(waitToSpawn);

        }
        spusteno = false;
        wave++;
    }
    IEnumerator wave12()
    {
        cisloWavy++;
        spusteno = true;
        for(int i = 0; i < 30; i++)
        {
            Instantiate(Dinosaurus_fast, SpawnPoint.position, SpawnPoint.rotation);
            yield return new WaitForSeconds(waitToSpawn);
        }
        for(int i = 0; i < 20; i++)
        {
            Instantiate(Dinosaurus_tank, SpawnPoint.position, SpawnPoint.rotation);
            yield return new WaitForSeconds(waitToSpawn);
        }
        spusteno = false;
        wave++;
    }
    IEnumerator wave13()
    {
        cisloWavy++;
        spusteno = true;
        for(int i = 0; i < 30; i++)
        {
            Instantiate(Dinosaurus_tank, SpawnPoint.position, SpawnPoint.rotation);
            yield return new WaitForSeconds(waitToSpawn);
        }
        spusteno = false;
        wave++;
    }
    IEnumerator wave14()
    {
        cisloWavy++;
        spusteno = true;
        for(int i = 0; i < 10; i++)
        {
            Instantiate(Dinosaurus_basic, SpawnPoint.position, SpawnPoint.rotation);
            yield return new WaitForSeconds(waitToSpawn);
            Instantiate(Dinosaurus_basic, SpawnPoint.position, SpawnPoint.rotation);
            yield return new WaitForSeconds(waitToSpawn);
            Instantiate(Dinosaurus_basic, SpawnPoint.position, SpawnPoint.rotation);
            yield return new WaitForSeconds(waitToSpawn);
            Instantiate(Dinosaurus_basic, SpawnPoint.position, SpawnPoint.rotation);
            yield return new WaitForSeconds(waitToSpawn);
            Instantiate(Dinosaurus_tank, SpawnPoint.position, SpawnPoint.rotation);
            yield return new WaitForSeconds(waitToSpawn);
            Instantiate(Dinosaurus_basic, SpawnPoint.position, SpawnPoint.rotation);
            yield return new WaitForSeconds(waitToSpawn);
            Instantiate(Dinosaurus_basic, SpawnPoint.position, SpawnPoint.rotation);
            yield return new WaitForSeconds(waitToSpawn);
            Instantiate(Dinosaurus_basic, SpawnPoint.position, SpawnPoint.rotation);
            yield return new WaitForSeconds(waitToSpawn);
            Instantiate(Dinosaurus_basic, SpawnPoint.position, SpawnPoint.rotation);
            yield return new WaitForSeconds(waitToSpawn);
        }
        spusteno = false;
        wave++;
    }
    IEnumerator wave15()
    {
        cisloWavy++;
        spusteno = true;
        for(int i = 0; i < 50; i++)
        {
            Instantiate(Dinosaurus_fast, SpawnPoint.position, SpawnPoint.rotation);
            yield return new WaitForSeconds(waitToSpawn);
        }
        spusteno = false;
        wave++;
    }
    IEnumerator wave16()
    {
        cisloWavy++;
        spusteno = true;
            Instantiate(Dinosaurus_basic, SpawnPoint.position, SpawnPoint.rotation);
            yield return new WaitForSeconds(waitToSpawn);
        
        spusteno = false;
        wave++;
    }
    IEnumerator wave17()
    {
        cisloWavy++;
        spusteno = true;
        for(int i = 0; i < 7; i++)
        {
            Instantiate(Dinosaurus_fast, SpawnPoint.position, SpawnPoint.rotation);
            yield return new WaitForSeconds(waitToSpawn);
            Instantiate(Dinosaurus_strong, SpawnPoint.position, SpawnPoint.rotation);
            yield return new WaitForSeconds(waitToSpawn);
            Instantiate(Dinosaurus_fast, SpawnPoint.position, SpawnPoint.rotation);
            yield return new WaitForSeconds(waitToSpawn);
            Instantiate(Dinosaurus_tank, SpawnPoint.position, SpawnPoint.rotation);
            yield return new WaitForSeconds(waitToSpawn);
            Instantiate(Dinosaurus_fast, SpawnPoint.position, SpawnPoint.rotation);
            yield return new WaitForSeconds(waitToSpawn);
            Instantiate(Dinosaurus_strong, SpawnPoint.position, SpawnPoint.rotation);
            yield return new WaitForSeconds(waitToSpawn);
            Instantiate(Dinosaurus_fast, SpawnPoint.position, SpawnPoint.rotation);
            yield return new WaitForSeconds(waitToSpawn);
        }
        spusteno = false;
        wave++;
    }
    IEnumerator wave18()
    {
        cisloWavy++;
        spusteno = true;
        for(int i = 0; i < 60; i++)
        {
            Instantiate(Dinosaurus_strong, SpawnPoint.position, SpawnPoint.rotation);
            yield return new WaitForSeconds(waitToSpawn);
        }
        spusteno = false;
        wave++;
    }
    IEnumerator wave19()
    {
        cisloWavy++;
        spusteno = true;
        for(int i = 0; i < 60; i++)
        {
            Instantiate(Dinosaurus_fast, SpawnPoint.position, SpawnPoint.rotation);
            yield return new WaitForSeconds(waitToSpawn);
        }
        spusteno = false;
        wave++;
    }
    IEnumerator wave20()
    {
        cisloWavy++;
        spusteno = true;
        for(int i = 0; i < 7; i++)
        {
            Instantiate(Dinosaurus_basic, SpawnPoint.position, SpawnPoint.rotation);
            yield return new WaitForSeconds(waitToSpawn);
            Instantiate(Dinosaurus_basic, SpawnPoint.position, SpawnPoint.rotation);
            yield return new WaitForSeconds(waitToSpawn);
            Instantiate(Dinosaurus_basic, SpawnPoint.position, SpawnPoint.rotation);
            yield return new WaitForSeconds(waitToSpawn);
            Instantiate(Dinosaurus_basic, SpawnPoint.position, SpawnPoint.rotation);
            yield return new WaitForSeconds(waitToSpawn);
            Instantiate(Dinosaurus_basic, SpawnPoint.position, SpawnPoint.rotation);
            yield return new WaitForSeconds(waitToSpawn);
            Instantiate(Dinosaurus_basic, SpawnPoint.position, SpawnPoint.rotation);
            yield return new WaitForSeconds(waitToSpawn);
            Instantiate(Dinosaurus_basic, SpawnPoint.position, SpawnPoint.rotation);
            yield return new WaitForSeconds(waitToSpawn);
            Instantiate(Dinosaurus_basic, SpawnPoint.position, SpawnPoint.rotation);
            yield return new WaitForSeconds(waitToSpawn);
            Instantiate(Dinosaurus_basic, SpawnPoint.position, SpawnPoint.rotation);
            yield return new WaitForSeconds(waitToSpawn);
            Instantiate(Dinosaurus_strong, SpawnPoint.position, SpawnPoint.rotation);
            yield return new WaitForSeconds(waitToSpawn);
            Instantiate(Dinosaurus_strong, SpawnPoint.position, SpawnPoint.rotation);
            yield return new WaitForSeconds(waitToSpawn);
            Instantiate(Dinosaurus_fast, SpawnPoint.position, SpawnPoint.rotation);
            yield return new WaitForSeconds(waitToSpawn);
            Instantiate(Dinosaurus_fast, SpawnPoint.position, SpawnPoint.rotation);
            yield return new WaitForSeconds(waitToSpawn);
            Instantiate(Dinosaurus_fast, SpawnPoint.position, SpawnPoint.rotation);
            yield return new WaitForSeconds(waitToSpawn);
            Instantiate(Dinosaurus_fast, SpawnPoint.position, SpawnPoint.rotation);
            yield return new WaitForSeconds(waitToSpawn);
            Instantiate(Dinosaurus_tank, SpawnPoint.position, SpawnPoint.rotation);
            yield return new WaitForSeconds(waitToSpawn);


        }
        spusteno = false;
        wave++;
    }
    IEnumerator wave21()
    {
        cisloWavy++;
        spusteno = true;
        for(int i = 0; i < 50; i++)
        {
            Instantiate(Dinosaurus_tank, SpawnPoint.position, SpawnPoint.rotation);
            yield return new WaitForSeconds(waitToSpawn);
        }
        spusteno = false;
        wave++;
    }
    IEnumerator wave22()
    {
        cisloWavy++;
        spusteno = true;
        for(int i = 0; i < 80; i++)
        {
            Instantiate(Dinosaurus_fast, SpawnPoint.position, SpawnPoint.rotation);
            yield return new WaitForSeconds(waitToSpawn);
        }
        spusteno = false;
        wave++;
    }
    IEnumerator wave23()
    {
        cisloWavy++;
        spusteno = true;
        for(int i = 0; i < 20; i++)
        {
            Instantiate(Dinosaurus_tank, SpawnPoint.position, SpawnPoint.rotation);
            yield return new WaitForSeconds(waitToSpawn);
            Instantiate(Dinosaurus_fast, SpawnPoint.position, SpawnPoint.rotation);
            yield return new WaitForSeconds(waitToSpawn);
            Instantiate(Dinosaurus_basic, SpawnPoint.position, SpawnPoint.rotation);
            yield return new WaitForSeconds(waitToSpawn);
            Instantiate(Dinosaurus_fast, SpawnPoint.position, SpawnPoint.rotation);
            yield return new WaitForSeconds(waitToSpawn);
            Instantiate(Dinosaurus_tank, SpawnPoint.position, SpawnPoint.rotation);
            yield return new WaitForSeconds(waitToSpawn);
            Instantiate(Dinosaurus_tank, SpawnPoint.position, SpawnPoint.rotation);
            yield return new WaitForSeconds(waitToSpawn);
        }
        spusteno = false;
        wave++;
    }
    IEnumerator wave24()
    {
        cisloWavy++;
        spusteno = true;
        for(int i = 0; i < 89; i++)
        {
            Instantiate(Dinosaurus_strong, SpawnPoint.position, SpawnPoint.rotation);
            yield return new WaitForSeconds(waitToSpawn);
        }
        spusteno = false;
        wave++;
    }
    IEnumerator wave25()
    {
        cisloWavy++;
        spusteno = true;
        for(int i = 0; i < 50; i++)
        {
            Instantiate(Dinosaurus_basic, SpawnPoint.position, SpawnPoint.rotation);
            yield return new WaitForSeconds(waitToSpawn);
            Instantiate(Dinosaurus_fast, SpawnPoint.position, SpawnPoint.rotation);
            yield return new WaitForSeconds(waitToSpawn);
            Instantiate(Dinosaurus_strong, SpawnPoint.position, SpawnPoint.rotation);
            yield return new WaitForSeconds(waitToSpawn);
        }
        spusteno = false;
        wave++;
    }
    IEnumerator wave26()
    {
        cisloWavy++;
        spusteno = true;
        for(int i = 0; i < 70; i++)
        {
            Instantiate(Dinosaurus_tank, SpawnPoint.position, SpawnPoint.rotation);
            yield return new WaitForSeconds(waitToSpawn);
        }
        spusteno = false;
        wave++;
    }
    IEnumerator wave27()
    {
        cisloWavy++;
        spusteno = true;
        for(int i = 0; i < 50; i++)
        {
            Instantiate(Dinosaurus_fast, SpawnPoint.position, SpawnPoint.rotation);
            yield return new WaitForSeconds(waitToSpawn);
            Instantiate(Dinosaurus_tank, SpawnPoint.position, SpawnPoint.rotation);
            yield return new WaitForSeconds(waitToSpawn);
        }
        spusteno = false;
        wave++;
    }
    IEnumerator wave28()
    {
        cisloWavy++;
        spusteno = true;
        for(int i = 0; i < 20; i++)
        {
            Instantiate(Dinosaurus_strong, SpawnPoint.position, SpawnPoint.rotation);
            yield return new WaitForSeconds(waitToSpawn);
        }
        for(int i = 0; i < 69; i++)
        {
            Instantiate(Dinosaurus_tank, SpawnPoint.position, SpawnPoint.rotation);
            yield return new WaitForSeconds(waitToSpawn);
        }
        spusteno = false;
        wave++;
    }
    IEnumerator wave29()
    {
        cisloWavy++;
        spusteno = true;
        for(int i = 0; i < 50; i++)
        {
            Instantiate(Dinosaurus_tank, SpawnPoint.position, SpawnPoint.rotation);
            yield return new WaitForSeconds(waitToSpawn);
            Instantiate(Dinosaurus_strong, SpawnPoint.position, SpawnPoint.rotation);
            yield return new WaitForSeconds(waitToSpawn);
        }
        spusteno = false;
        wave++;
    }
    IEnumerator wave30()
    {
        cisloWavy++;
        spusteno = true;
        for(int i = 0; i < 10; i++)
        {
            Instantiate(Dinosaurus_basic, SpawnPoint.position, SpawnPoint.rotation);
            yield return new WaitForSeconds(waitToSpawn);
            Instantiate(Dinosaurus_strong, SpawnPoint.position, SpawnPoint.rotation);
            yield return new WaitForSeconds(waitToSpawn);
            Instantiate(Dinosaurus_strong, SpawnPoint.position, SpawnPoint.rotation);
            yield return new WaitForSeconds(waitToSpawn);
            Instantiate(Dinosaurus_strong, SpawnPoint.position, SpawnPoint.rotation);
            yield return new WaitForSeconds(waitToSpawn);
        }
        for(int i = 0; i < 70; i++)
        {
            Instantiate(Dinosaurus_tank, SpawnPoint.position, SpawnPoint.rotation);
            yield return new WaitForSeconds(waitToSpawn);
          
        }
        for(int i = 0; i < 50; i++)
        {
            Instantiate(Dinosaurus_fast, SpawnPoint.position, SpawnPoint.rotation);
            yield return new WaitForSeconds(waitToSpawn);
        }
        spusteno = false;
        wave++;
    }
    public void backToMenuDone()
    {
        SceneManager.LoadScene("HlavniMenu");
        
        if(level > skript.nejvyssiDosazeny)skript.nejvyssiDosazeny = level + 1;
        print("level: "+level);
        
        print("dokončeno: "+skript.LevelFinished);
        
        /*switch (level)
        {
            case 1:
            if(level == skript.LevelFinished)skript.LevelFinished = 2;
            level++;
            print(skript.LevelFinished);
            break;

            case 2:
            if(level == skript.LevelFinished)skript.LevelFinished = 3;
            level++;
            break;

            case 3:
            if(level == skript.LevelFinished)skript.LevelFinished = 4;
            level++;
            break;

            case 4:
            if(level == skript.LevelFinished)skript.LevelFinished = 5;
            level++;
            break;
            
            case 5:
            if(level == skript.LevelFinished)skript.LevelFinished = 6;
            level++;
            break;
            
            case 6:
            if(level == skript.LevelFinished)skript.LevelFinished = 7;
            level++;
            break;

            case 7:
            if(level == skript.LevelFinished)skript.LevelFinished = 8;
            level++;
            break;

            case 8:
            if(level == skript.LevelFinished)skript.LevelFinished = 9;
            level++;
            break;

            case 9:
            if(level == skript.LevelFinished)skript.LevelFinished = 10;
            level++;
            break;
            
            case 10:
            if(level == skript.LevelFinished)skript.LevelFinished = 11;
            level++;
            break;
        }*/

        print(skript.LevelFinished);
        killed = 0;
        penize = 1000;
        zivoty = 100;
        wave = 1;
        doubleS = false;
 
        skript.SaveProgress();
    }
    public void backToMenuFailed()
    {
        SceneManager.LoadScene("HlavniMenu");
        killed = 0;
        penize = 1000;
        zivoty = 100;
        wave = 1;
        doubleS = false;
    }

    public void restartLevel1()
    {
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
       zivoty = 100;
       penize = 1000;
       //start = false;
       killed = 0;
       wave = 1;
       doubleS = false;
    }
    public void restartLevel2()
    {
        SceneManager.LoadScene("Level2");
        zivoty = 100;
        penize = 1000;
        //start = false;
        killed = 0;
        wave = 1;
        doubleS = false;
    }
    public void restartLevel3()
    {
        SceneManager.LoadScene("Level3");
        zivoty = 100;
        penize = 1000;
        //start = false;
        killed = 0;
        wave = 1;
        doubleS = false;

    }
    public void restartLevel4()
    {
        SceneManager.LoadScene("Level4");
        zivoty = 100;
        penize = 1000;
        //start = false;
        killed = 0;
        wave = 1;
        doubleS = false;
    }
    public void restartLevel5()
    {
        SceneManager.LoadScene("Level5");
        zivoty = 100;
        penize = 1000;
        //start = false;
        killed = 0;
        wave = 1;
        doubleS = false;
    }
    public void restartLevel6()
    {
        SceneManager.LoadScene("Level6");
        zivoty = 100;
        penize = 1000;
        //start = false;
        killed = 0;
        wave = 1;
        doubleS = false;
    }
    public void restartLevel7()
    {
        SceneManager.LoadScene("Level7");
        zivoty = 100;
        penize = 1000;
        //start = false;
        killed = 0;
        wave = 1;
        doubleS = false;
    }
    public void restartLevel8()
    {
        SceneManager.LoadScene("Level8");
        zivoty = 100;
        penize = 1000;
        //start = false;
        killed = 0;
        wave = 1;
        doubleS = false;
    }
    public void restartLevel9()
    {
        SceneManager.LoadScene("Level9");
        zivoty = 100;
        penize = 1000;
        //start = false;
        killed = 0;
        wave = 1;
        doubleS = false;
    }
    public void restartLevel10()
    {
        SceneManager.LoadScene("Level10");
        zivoty = 100;
        penize = 1000;
        //start = false;
        killed = 0;
        wave = 1;
        doubleS = false;
    }

    public void automat()
    {
        if(auto == false)auto = true;
        else auto = false;
    }
    public void gameSpeed()
    {
        if(doubleS == false)doubleS = true;
        else doubleS = false;
    }

    

}
