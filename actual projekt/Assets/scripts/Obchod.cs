using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Obchod : MonoBehaviour
{
    int koupenaTresen;
    bool jeKoupenaTresen;
    public GameObject tlacitko;
    public GameObject tresenBasic;
    public GameObject tresenSniper;
    public GameObject tresenRambo;


    void Start()
    {
        tlacitko.SetActive(false);
    }

    public void polozitTresen()
    {
        if (koupenaTresen == 150)
        {
            var mousePositionInWorld = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Instantiate(tresenBasic, new Vector3(mousePositionInWorld.x, mousePositionInWorld.y, 0), Quaternion.identity);
            tlacitko.SetActive(false);
            jeKoupenaTresen = false;
        }
        else if (koupenaTresen == 500)
        {
            var mousePositionInWorld = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Instantiate(tresenSniper, new Vector3(mousePositionInWorld.x, mousePositionInWorld.y, 0), Quaternion.identity);
            tlacitko.SetActive(false);
            jeKoupenaTresen = false;
        }
        else if (koupenaTresen == 800)
        {
            var mousePositionInWorld = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Instantiate(tresenRambo, new Vector3(mousePositionInWorld.x, mousePositionInWorld.y, 0), Quaternion.identity);
            tlacitko.SetActive(false);
            jeKoupenaTresen = false;
        }
    }

    public void TresenBasic()
    {
        if (jeKoupenaTresen)
        {
            Spawner.penize = Spawner.penize + koupenaTresen;
            jeKoupenaTresen = false;
        }
        else
        {
            koupenaTresen = 150;
            Spawner.penize = Spawner.penize - 150;
            if (Spawner.penize <= 0)
            {
                Spawner.penize = Spawner.penize + 150;
            }
            else
            {
                jeKoupenaTresen = true;
                tlacitko.SetActive(true);
            }
        }
    }

    public void TresenSniper()
    {
        if (jeKoupenaTresen)
        {
            Spawner.penize = Spawner.penize + koupenaTresen;
            jeKoupenaTresen = false;
        }
        else
        {
            koupenaTresen = 500;
            Spawner.penize = Spawner.penize - 500;
            if (Spawner.penize <= 0)
            {
                Spawner.penize = Spawner.penize + 500;
            }
            else
            {
                jeKoupenaTresen = true;
                tlacitko.SetActive(true);
            }
        }
    }
    public void TresenRambo()
    {
        if (jeKoupenaTresen)
        {
            Spawner.penize = Spawner.penize + koupenaTresen;
            jeKoupenaTresen = false;
        }
        else
        {
            koupenaTresen = 800;
            Spawner.penize = Spawner.penize - 800;
            if (Spawner.penize <= 0)
            {
                Spawner.penize = Spawner.penize + 800;
            }
            else
            {
                jeKoupenaTresen = true;
                tlacitko.SetActive(true);
            }
        }
    }
}
