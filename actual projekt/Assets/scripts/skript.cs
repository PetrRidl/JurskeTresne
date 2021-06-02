using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class skript : MonoBehaviour
{
    public GameObject deny;
    public Transform denyLocation;
    public static int LevelFinished = 1;
    

    void Start()
    {
        LevelFinished = PlayerPrefs.GetInt("LevelFinished");
    }
    public static void SaveProgress()
    {
        PlayerPrefs.SetInt("LevelFinished", LevelFinished);
    }
    public void Hrat()
    {
        SceneManager.LoadScene("VyberLevelu");
    }
    public void Level1()
    {
        SceneManager.LoadScene("Level1");
    }
    public void Level2()
    {
        print(LevelFinished);
        if(LevelFinished >= 2)
        {
            SceneManager.LoadScene("Level2");
            print(LevelFinished);
        }    
        else Instantiate(deny, denyLocation.position, denyLocation.rotation);
    }
    public void Level3()
    {
        print(LevelFinished);
        if(LevelFinished >= 3)SceneManager.LoadScene("Level3");
        else Instantiate(deny, denyLocation.position, denyLocation.rotation);
    }
    public void Level4()
    {
        print(LevelFinished);
        if(LevelFinished >= 4)SceneManager.LoadScene("Level4");
        else Instantiate(deny, denyLocation.position, denyLocation.rotation);
    }
    public void Level5()
    {
        print(LevelFinished);
        if(LevelFinished >= 5)SceneManager.LoadScene("Level5");
        else Instantiate(deny, denyLocation.position, denyLocation.rotation);
    }
    public void Level6()
    {
        print(LevelFinished);
        if(LevelFinished >= 6)SceneManager.LoadScene("Level6");
        else Instantiate(deny, denyLocation.position, denyLocation.rotation);
    }
    public void Level7()
    {
        print(LevelFinished);
        if(LevelFinished >= 7)SceneManager.LoadScene("Level7");
        else Instantiate(deny, denyLocation.position, denyLocation.rotation);
    }
    public void Level8()
    {
        print(LevelFinished);
        if(LevelFinished >= 8)SceneManager.LoadScene("Level8");
        else Instantiate(deny, denyLocation.position, denyLocation.rotation);
    }
    public void Level9()
    {
        print(LevelFinished);
        if(LevelFinished >= 9)SceneManager.LoadScene("Level9");
        else Instantiate(deny, denyLocation.position, denyLocation.rotation);
    }
    public void Level10()
    {
        print(LevelFinished);
        if(LevelFinished >= 10)SceneManager.LoadScene("Level10");
        else Instantiate(deny, denyLocation.position, denyLocation.rotation);
    }
    
    public void Konec()
    {
        Application.Quit();
    }
}
