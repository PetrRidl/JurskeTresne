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
        Vector3 poziceTlacitka = GameObject.FindGameObjectWithTag("Vez").transform.position;
        poziceTlacitka[2] = -1;
        if (koupenaTresen == 150)
        {
            Instantiate(tresenBasic, poziceTlacitka, transform.rotation);
            tlacitko.SetActive(false);
            jeKoupenaTresen = false;
        }
        else if (koupenaTresen == 500)
        {
            Instantiate(tresenSniper, poziceTlacitka, transform.rotation);
            tlacitko.SetActive(false);
            jeKoupenaTresen = false;
        }
        else if (koupenaTresen == 800)
        {
            Instantiate(tresenRambo, poziceTlacitka, transform.rotation);
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
            jeKoupenaTresen = true;
            tlacitko.SetActive(true);
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
            jeKoupenaTresen = true;
            tlacitko.SetActive(true);
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
            jeKoupenaTresen = true;
            tlacitko.SetActive(true);
        }
    }
}
