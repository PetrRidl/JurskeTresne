using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obchod : MonoBehaviour
{
    bool koupenaTresenJedna = false;
    bool koupenaTresenDva = false;
    
    public void ZakoupenaTresenJedna()
    {
        if (koupenaTresenJedna == false && koupenaTresenDva == false)
        {
            Spawner.penize = Spawner.penize - 150;
            koupenaTresenJedna = true;

        }
        else if (koupenaTresenDva == true)
        {
            Spawner.penize = Spawner.penize + 300;
            koupenaTresenDva = false;
        }
        else
        {
            Spawner.penize = Spawner.penize + 150;
            koupenaTresenJedna = false;
        }
    }

    public void ZakoupenaTresenDva()
    {
        if (koupenaTresenJedna == false && koupenaTresenDva == false)
        {
            Spawner.penize = Spawner.penize - 300;
            koupenaTresenDva = true;
        }
        else if (koupenaTresenJedna == true)
        {
            Spawner.penize = Spawner.penize + 150;
            koupenaTresenJedna = false;
        }
        else
        {
            Spawner.penize = Spawner.penize + 300;
            koupenaTresenDva = false;
        }
    }
}
