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
    private int wave = 1;
    private int spawn;
    public static int killed;
    public int difficulty;
    private int toKill;
    private bool konec = false;
    private bool start = false;
    private bool spusteno = false;
   

    void Start()
    {
        konec = false;
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
    }
    
    void Update()
    {

        
        if(killed == toKill && zivoty > 0 && konec == false)
        {
            Instantiate(Vyhra, spawn_Konec.position, spawn_Konec.rotation);
            konec = true;
        }
        if(zivoty <= 0 && konec == false)
        {
            Instantiate(Prohra, spawn_Konec.position, spawn_Konec.rotation);
            konec = true;
        }
        if(zivoty < 0) zivoty = 0;
      

    }
    public void Spawn(){
       if(spusteno == false){ switch (wave)
        {
            case 1:
            StartCoroutine(wave1());
            wave++;
            break;

            case 2:
            StartCoroutine(wave2());
            wave++;
            break;

            case 3:
            StartCoroutine(wave3());
            wave++;
            break;

            case 4:
            StartCoroutine(wave4());
            wave++;
            break;

            case 5:
            StartCoroutine(wave5());
            wave++;
            break;

            case 6:
            StartCoroutine(wave6());
            wave++;
            break;

            case 7:
            StartCoroutine(wave7());
            wave++;
            break;

            case 8:
            StartCoroutine(wave8());
            wave++;
            break;

            case 9:
            StartCoroutine(wave9());
            wave++;
            break;

            case 10:
            StartCoroutine(wave10());
            wave++;
            break;

            case 11:
            StartCoroutine(wave11());
            wave++;
            break;

            case 12:
            StartCoroutine(wave12());
            wave++;
            break;

            case 13:
            StartCoroutine(wave13());
            wave++;
            break;

            case 14:
            StartCoroutine(wave14());
            wave++;
            break;

            case 15:
            StartCoroutine(wave15());
            wave++;
            break;

            case 16:
            StartCoroutine(wave16());
            wave++;
            break;

            case 17:
            StartCoroutine(wave17());
            wave++;
            break;

            case 18:
            StartCoroutine(wave18());
            wave++;
            break;

            case 19:
            StartCoroutine(wave19());
            wave++;
            break;

            case 20:
            StartCoroutine(wave20());
            wave++;
            break;

            case 21:
            StartCoroutine(wave21());
            wave++;
            break;

            case 22:
            StartCoroutine(wave22());
            wave++;
            break;

            case 23:
            StartCoroutine(wave23());
            wave++;
            break;

            case 24:
            StartCoroutine(wave24());
            wave++;
            break;

            case 25:
            StartCoroutine(wave25());
            wave++;
            break;

            case 26:
            StartCoroutine(wave26());
            wave++;
            break;

            case 27:
            StartCoroutine(wave27());
            wave++;
            break;

            case 28:
            StartCoroutine(wave28());
            wave++;
            break;

            case 29:
            StartCoroutine(wave29());
            wave++;
            break;

            case 30:
            StartCoroutine(wave30());
            wave++;
            break;
        }
        
    
        }
        else Instantiate(Odmitnuti, spawn_Konec.position, spawn_Konec.rotation);
     
                    
    }
    IEnumerator wave1()
    {
        spusteno = true;
        for(int i = 0; i < 4; i++)
        {
            Instantiate(Dinosaurus_basic, SpawnPoint.position, SpawnPoint.rotation);
            yield return new WaitForSeconds(0.5f);
        }
        spusteno = false;
        
        
    }
    IEnumerator wave2()
    {
        spusteno = true;
        for(int i = 0; i < 6; i++)
        {
            Instantiate(Dinosaurus_basic, SpawnPoint.position, SpawnPoint.rotation);
            yield return new WaitForSeconds(0.5f);
        }
        spusteno = false;
    }
    IEnumerator wave3()
    {
        spusteno = true;
        for(int i = 0; i < 9; i++)
        {

            Instantiate(Dinosaurus_basic, SpawnPoint.position, SpawnPoint.rotation);
            yield return new WaitForSeconds(0.5f);
        }
        Instantiate(Dinosaurus_strong, SpawnPoint.position, SpawnPoint.rotation);
        spusteno = false;
    }
    IEnumerator wave4()
    {
        spusteno = true;
      for(int i = 0; i < 5; i++)
        {

            Instantiate(Dinosaurus_strong, SpawnPoint.position, SpawnPoint.rotation);
            yield return new WaitForSeconds(0.5f);
        }
        spusteno = false;
    }
    IEnumerator wave5()
    {
        spusteno = true;
        for(int i = 0; i < 7; i++)
        {

            Instantiate(Dinosaurus_strong, SpawnPoint.position, SpawnPoint.rotation);
            yield return new WaitForSeconds(0.5f);
        }
        spusteno = false;
    }
    IEnumerator wave6()
    {
        spusteno = true;
        for(int i = 0; i < 9; i++)
        {
            Instantiate(Dinosaurus_strong, SpawnPoint.position, SpawnPoint.rotation);
            yield return new WaitForSeconds(0.5f);
        }
        spusteno = false;
    }
    IEnumerator wave7()
    {
        spusteno = true;
        for(int i = 0; i < 5; i++)
        {
            Instantiate(Dinosaurus_strong, SpawnPoint.position, SpawnPoint.rotation);
            yield return new WaitForSeconds(0.5f);
            Instantiate(Dinosaurus_fast, SpawnPoint.position, SpawnPoint.rotation);
            yield return new WaitForSeconds(0.5f);
            Instantiate(Dinosaurus_strong, SpawnPoint.position, SpawnPoint.rotation);
            yield return new WaitForSeconds(0.5f);
        }
        spusteno = false;
    }
    IEnumerator wave8()
    {
        spusteno = true;
        for(int i = 0; i < 10; i++)
        {
            Instantiate(Dinosaurus_basic, SpawnPoint.position, SpawnPoint.rotation);
            yield return new WaitForSeconds(0.5f);
            Instantiate(Dinosaurus_fast, SpawnPoint.position, SpawnPoint.rotation);
            yield return new WaitForSeconds(0.5f);
        }
        spusteno = false;
    }
    IEnumerator wave9()
    {
        spusteno = true;
        for(int i = 0; i < 10; i++)
        {
            Instantiate(Dinosaurus_tank, SpawnPoint.position, SpawnPoint.rotation);
            yield return new WaitForSeconds(0.5f);
            Instantiate(Dinosaurus_fast, SpawnPoint.position, SpawnPoint.rotation);
            yield return new WaitForSeconds(0.5f);
        }
        spusteno = false;
    }
    IEnumerator wave10()
    {
        spusteno = true;
        for(int i = 0; i < 10; i++)
        {
            Instantiate(Dinosaurus_basic, SpawnPoint.position, SpawnPoint.rotation);
            yield return new WaitForSeconds(0.5f);
            Instantiate(Dinosaurus_strong, SpawnPoint.position, SpawnPoint.rotation);
            yield return new WaitForSeconds(0.5f);
            Instantiate(Dinosaurus_tank, SpawnPoint.position, SpawnPoint.rotation);
            yield return new WaitForSeconds(0.5f);
            Instantiate(Dinosaurus_fast, SpawnPoint.position, SpawnPoint.rotation);
            yield return new WaitForSeconds(0.5f);
        }
        spusteno = false;
    }
    IEnumerator wave11()
    {
        spusteno = true;
        for(int i = 0; i < 50; i++)
        {
            Instantiate(Dinosaurus_basic, SpawnPoint.position, SpawnPoint.rotation);
            yield return new WaitForSeconds(0.5f);

        }
        for(int i = 0; i < 20; i++)
        {
            Instantiate(Dinosaurus_fast, SpawnPoint.position, SpawnPoint.rotation);
            yield return new WaitForSeconds(0.5f);

        }
        spusteno = false;
    }
    IEnumerator wave12()
    {
        spusteno = true;
        for(int i = 0; i < 30; i++)
        {
            Instantiate(Dinosaurus_fast, SpawnPoint.position, SpawnPoint.rotation);
            yield return new WaitForSeconds(0.5f);
        }
        for(int i = 0; i < 20; i++)
        {
            Instantiate(Dinosaurus_tank, SpawnPoint.position, SpawnPoint.rotation);
            yield return new WaitForSeconds(0.5f);
        }
        spusteno = false;
    }
    IEnumerator wave13()
    {
        spusteno = true;
        for(int i = 0; i < 30; i++)
        {
            Instantiate(Dinosaurus_tank, SpawnPoint.position, SpawnPoint.rotation);
            yield return new WaitForSeconds(0.5f);
        }
        spusteno = false;
    }
    IEnumerator wave14()
    {
        spusteno = true;
        for(int i = 0; i < 10; i++)
        {
            Instantiate(Dinosaurus_basic, SpawnPoint.position, SpawnPoint.rotation);
            yield return new WaitForSeconds(0.5f);
            Instantiate(Dinosaurus_basic, SpawnPoint.position, SpawnPoint.rotation);
            yield return new WaitForSeconds(0.5f);
            Instantiate(Dinosaurus_basic, SpawnPoint.position, SpawnPoint.rotation);
            yield return new WaitForSeconds(0.5f);
            Instantiate(Dinosaurus_basic, SpawnPoint.position, SpawnPoint.rotation);
            yield return new WaitForSeconds(0.5f);
            Instantiate(Dinosaurus_tank, SpawnPoint.position, SpawnPoint.rotation);
            yield return new WaitForSeconds(0.5f);
            Instantiate(Dinosaurus_basic, SpawnPoint.position, SpawnPoint.rotation);
            yield return new WaitForSeconds(0.5f);
            Instantiate(Dinosaurus_basic, SpawnPoint.position, SpawnPoint.rotation);
            yield return new WaitForSeconds(0.5f);
            Instantiate(Dinosaurus_basic, SpawnPoint.position, SpawnPoint.rotation);
            yield return new WaitForSeconds(0.5f);
            Instantiate(Dinosaurus_basic, SpawnPoint.position, SpawnPoint.rotation);
            yield return new WaitForSeconds(0.5f);
        }
        spusteno = false;
    }
    IEnumerator wave15()
    {
        spusteno = true;
        for(int i = 0; i < 50; i++)
        {
            Instantiate(Dinosaurus_fast, SpawnPoint.position, SpawnPoint.rotation);
            yield return new WaitForSeconds(0.5f);
        }
        spusteno = false;
    }
    IEnumerator wave16()
    {
        spusteno = true;
            Instantiate(Dinosaurus_basic, SpawnPoint.position, SpawnPoint.rotation);
            yield return new WaitForSeconds(0.5f);
        
        spusteno = false;
    }
    IEnumerator wave17()
    {
        spusteno = true;
        for(int i = 0; i < 7; i++)
        {
            Instantiate(Dinosaurus_fast, SpawnPoint.position, SpawnPoint.rotation);
            yield return new WaitForSeconds(0.5f);
            Instantiate(Dinosaurus_strong, SpawnPoint.position, SpawnPoint.rotation);
            yield return new WaitForSeconds(0.5f);
            Instantiate(Dinosaurus_fast, SpawnPoint.position, SpawnPoint.rotation);
            yield return new WaitForSeconds(0.5f);
            Instantiate(Dinosaurus_tank, SpawnPoint.position, SpawnPoint.rotation);
            yield return new WaitForSeconds(0.5f);
            Instantiate(Dinosaurus_fast, SpawnPoint.position, SpawnPoint.rotation);
            yield return new WaitForSeconds(0.5f);
            Instantiate(Dinosaurus_strong, SpawnPoint.position, SpawnPoint.rotation);
            yield return new WaitForSeconds(0.5f);
            Instantiate(Dinosaurus_fast, SpawnPoint.position, SpawnPoint.rotation);
            yield return new WaitForSeconds(0.5f);
        }
        spusteno = false;
    }
    IEnumerator wave18()
    {
        spusteno = true;
        for(int i = 0; i < 60; i++)
        {
            Instantiate(Dinosaurus_strong, SpawnPoint.position, SpawnPoint.rotation);
            yield return new WaitForSeconds(0.5f);
        }
        spusteno = false;
    }
    IEnumerator wave19()
    {
        spusteno = true;
        for(int i = 0; i < 60; i++)
        {
            Instantiate(Dinosaurus_fast, SpawnPoint.position, SpawnPoint.rotation);
            yield return new WaitForSeconds(0.5f);
        }
        spusteno = false;
    }
    IEnumerator wave20()
    {
        spusteno = true;
        for(int i = 0; i < 7; i++)
        {
            Instantiate(Dinosaurus_basic, SpawnPoint.position, SpawnPoint.rotation);
            yield return new WaitForSeconds(0.5f);
            Instantiate(Dinosaurus_basic, SpawnPoint.position, SpawnPoint.rotation);
            yield return new WaitForSeconds(0.5f);
            Instantiate(Dinosaurus_basic, SpawnPoint.position, SpawnPoint.rotation);
            yield return new WaitForSeconds(0.5f);
            Instantiate(Dinosaurus_basic, SpawnPoint.position, SpawnPoint.rotation);
            yield return new WaitForSeconds(0.5f);
            Instantiate(Dinosaurus_basic, SpawnPoint.position, SpawnPoint.rotation);
            yield return new WaitForSeconds(0.5f);
            Instantiate(Dinosaurus_basic, SpawnPoint.position, SpawnPoint.rotation);
            yield return new WaitForSeconds(0.5f);
            Instantiate(Dinosaurus_basic, SpawnPoint.position, SpawnPoint.rotation);
            yield return new WaitForSeconds(0.5f);
            Instantiate(Dinosaurus_basic, SpawnPoint.position, SpawnPoint.rotation);
            yield return new WaitForSeconds(0.5f);
            Instantiate(Dinosaurus_basic, SpawnPoint.position, SpawnPoint.rotation);
            yield return new WaitForSeconds(0.5f);
            Instantiate(Dinosaurus_strong, SpawnPoint.position, SpawnPoint.rotation);
            yield return new WaitForSeconds(0.5f);
            Instantiate(Dinosaurus_strong, SpawnPoint.position, SpawnPoint.rotation);
            yield return new WaitForSeconds(0.5f);
            Instantiate(Dinosaurus_fast, SpawnPoint.position, SpawnPoint.rotation);
            yield return new WaitForSeconds(0.5f);
            Instantiate(Dinosaurus_fast, SpawnPoint.position, SpawnPoint.rotation);
            yield return new WaitForSeconds(0.5f);
            Instantiate(Dinosaurus_fast, SpawnPoint.position, SpawnPoint.rotation);
            yield return new WaitForSeconds(0.5f);
            Instantiate(Dinosaurus_fast, SpawnPoint.position, SpawnPoint.rotation);
            yield return new WaitForSeconds(0.5f);
            Instantiate(Dinosaurus_tank, SpawnPoint.position, SpawnPoint.rotation);
            yield return new WaitForSeconds(0.5f);


        }
        spusteno = false;
    }
    IEnumerator wave21()
    {
        spusteno = true;
        for(int i = 0; i < 50; i++)
        {
            Instantiate(Dinosaurus_tank, SpawnPoint.position, SpawnPoint.rotation);
            yield return new WaitForSeconds(0.5f);
        }
        spusteno = false;
    }
    IEnumerator wave22()
    {
        spusteno = true;
        for(int i = 0; i < 80; i++)
        {
            Instantiate(Dinosaurus_fast, SpawnPoint.position, SpawnPoint.rotation);
            yield return new WaitForSeconds(0.5f);
        }
        spusteno = false;
    }
    IEnumerator wave23()
    {
        spusteno = true;
        for(int i = 0; i < 20; i++)
        {
            Instantiate(Dinosaurus_tank, SpawnPoint.position, SpawnPoint.rotation);
            yield return new WaitForSeconds(0.5f);
            Instantiate(Dinosaurus_fast, SpawnPoint.position, SpawnPoint.rotation);
            yield return new WaitForSeconds(0.5f);
            Instantiate(Dinosaurus_basic, SpawnPoint.position, SpawnPoint.rotation);
            yield return new WaitForSeconds(0.5f);
            Instantiate(Dinosaurus_fast, SpawnPoint.position, SpawnPoint.rotation);
            yield return new WaitForSeconds(0.5f);
            Instantiate(Dinosaurus_tank, SpawnPoint.position, SpawnPoint.rotation);
            yield return new WaitForSeconds(0.5f);
            Instantiate(Dinosaurus_tank, SpawnPoint.position, SpawnPoint.rotation);
            yield return new WaitForSeconds(0.5f);
        }
        spusteno = false;
    }
    IEnumerator wave24()
    {
        spusteno = true;
        for(int i = 0; i < 89; i++)
        {
            Instantiate(Dinosaurus_strong, SpawnPoint.position, SpawnPoint.rotation);
            yield return new WaitForSeconds(0.5f);
        }
        spusteno = false;
    }
    IEnumerator wave25()
    {
        spusteno = true;
        for(int i = 0; i < 50; i++)
        {
            Instantiate(Dinosaurus_basic, SpawnPoint.position, SpawnPoint.rotation);
            yield return new WaitForSeconds(0.5f);
            Instantiate(Dinosaurus_fast, SpawnPoint.position, SpawnPoint.rotation);
            yield return new WaitForSeconds(0.5f);
            Instantiate(Dinosaurus_strong, SpawnPoint.position, SpawnPoint.rotation);
            yield return new WaitForSeconds(0.5f);
        }
        spusteno = false;
    }
    IEnumerator wave26()
    {
        spusteno = true;
        for(int i = 0; i < 70; i++)
        {
            Instantiate(Dinosaurus_tank, SpawnPoint.position, SpawnPoint.rotation);
            yield return new WaitForSeconds(0.5f);
        }
        spusteno = false;
    }
    IEnumerator wave27()
    {
        spusteno = true;
        for(int i = 0; i < 50; i++)
        {
            Instantiate(Dinosaurus_fast, SpawnPoint.position, SpawnPoint.rotation);
            yield return new WaitForSeconds(0.5f);
            Instantiate(Dinosaurus_tank, SpawnPoint.position, SpawnPoint.rotation);
            yield return new WaitForSeconds(0.5f);
        }
        spusteno = false;
    }
    IEnumerator wave28()
    {
        spusteno = true;
        for(int i = 0; i < 20; i++)
        {
            Instantiate(Dinosaurus_strong, SpawnPoint.position, SpawnPoint.rotation);
            yield return new WaitForSeconds(0.5f);
        }
        for(int i = 0; i < 69; i++)
        {
            Instantiate(Dinosaurus_tank, SpawnPoint.position, SpawnPoint.rotation);
            yield return new WaitForSeconds(0.5f);
        }
        spusteno = false;
    }
    IEnumerator wave29()
    {
        spusteno = true;
        for(int i = 0; i < 50; i++)
        {
            Instantiate(Dinosaurus_tank, SpawnPoint.position, SpawnPoint.rotation);
            yield return new WaitForSeconds(0.5f);
            Instantiate(Dinosaurus_strong, SpawnPoint.position, SpawnPoint.rotation);
            yield return new WaitForSeconds(0.5f);
        }
        spusteno = false;
    }
    IEnumerator wave30()
    {
        spusteno = true;
        for(int i = 0; i < 10; i++)
        {
            Instantiate(Dinosaurus_basic, SpawnPoint.position, SpawnPoint.rotation);
            yield return new WaitForSeconds(0.5f);
            Instantiate(Dinosaurus_strong, SpawnPoint.position, SpawnPoint.rotation);
            yield return new WaitForSeconds(0.5f);
            Instantiate(Dinosaurus_strong, SpawnPoint.position, SpawnPoint.rotation);
            yield return new WaitForSeconds(0.5f);
            Instantiate(Dinosaurus_strong, SpawnPoint.position, SpawnPoint.rotation);
            yield return new WaitForSeconds(0.5f);
        }
        for(int i = 0; i < 70; i++)
        {
            Instantiate(Dinosaurus_tank, SpawnPoint.position, SpawnPoint.rotation);
            yield return new WaitForSeconds(0.5f);
          
        }
        for(int i = 0; i < 50; i++)
        {
            Instantiate(Dinosaurus_fast, SpawnPoint.position, SpawnPoint.rotation);
            yield return new WaitForSeconds(0.5f);
        }
        spusteno = false;
    }
    public void backToMenuDone()
    {
        SceneManager.LoadScene("HlavniMenu");
        //skript.LevelFinished++;
        switch (level)
        {
            case 1:
            if(level == skript.LevelFinished)skript.LevelFinished = 2;
            break;

            case 2:
            if(level == skript.LevelFinished)skript.LevelFinished = 3;
            break;

            case 3:
            if(level == skript.LevelFinished)skript.LevelFinished = 4;
            break;

            case 4:
            if(level == skript.LevelFinished)skript.LevelFinished = 5;
            break;
            
            case 5:
            if(level == skript.LevelFinished)skript.LevelFinished = 6;
            break;
            
            case 6:
            if(level == skript.LevelFinished)skript.LevelFinished = 7;
            break;

            case 7:
            if(level == skript.LevelFinished)skript.LevelFinished = 8;
            break;

            case 8:
            if(level == skript.LevelFinished)skript.LevelFinished = 9;
            break;

            case 9:
            if(level == skript.LevelFinished)skript.LevelFinished = 10;
            break;
            
            case 10:
            if(level == skript.LevelFinished)skript.LevelFinished = 11;
            break;
        }
        killed = 0;
        penize = 1000;
        zivoty = 100;
 
        skript.SaveProgress();
    }
    public void backToMenuFailed()
    {
        SceneManager.LoadScene("HlavniMenu");
        killed = 0;
        penize = 1000;
        zivoty = 100;
    }

    public void restartLevel1()
    {
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
       zivoty = 100;
       penize = 1000;
       //start = false;
       killed = 0;
    }
    public void restartLevel2()
    {
        SceneManager.LoadScene("Level2");
        zivoty = 100;
        penize = 1000;
        //start = false;
        killed = 0;
    }
    public void restartLevel3()
    {
        SceneManager.LoadScene("Level3");
        zivoty = 100;
        penize = 1000;
        //start = false;
        killed = 0;

    }
    public void restartLevel4()
    {
        SceneManager.LoadScene("Level4");
        zivoty = 100;
        penize = 1000;
        //start = false;
        killed = 0;
    }
    public void restartLevel5()
    {
        SceneManager.LoadScene("Level5");
        zivoty = 100;
        penize = 1000;
        //start = false;
        killed = 0;
    }
    public void restartLevel6()
    {
        SceneManager.LoadScene("Level6");
        zivoty = 100;
        penize = 1000;
        //start = false;
        killed = 0;
    }
    public void restartLevel7()
    {
        SceneManager.LoadScene("Level7");
        zivoty = 100;
        penize = 1000;
        //start = false;
        killed = 0;
    }
    public void restartLevel8()
    {
        SceneManager.LoadScene("Level8");
        zivoty = 100;
        penize = 1000;
        //start = false;
        killed = 0;
    }
    public void restartLevel9()
    {
        SceneManager.LoadScene("Level9");
        zivoty = 100;
        penize = 1000;
        //start = false;
        killed = 0;
    }
    public void restartLevel10()
    {
        SceneManager.LoadScene("Level10");
        zivoty = 100;
        penize = 1000;
        //start = false;
        killed = 0;
    }



    

}
