using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class skript : MonoBehaviour
{
    public void Hrat()
    {
        SceneManager.LoadScene("VyberLevelu");
    }
    public void Level1()
    {
        SceneManager.LoadScene("Level1");
    }
    public void Konec()
    {
        Application.Quit();
    }
}
