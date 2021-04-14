using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CodeMonkey;
using CodeMonkey.Utils;

public class Friendly : MonoBehaviour
{
    private Transform cil;
    public int damage;
    public float range;
    
    private float rotace;
    public GameObject pfPecka;
    public Transform poziceStrelby;


    private void Awake(){
       
    }

    
    void Update()
    {

        Utok();
    }

    private void Utok()
    {
        
        //if(Input.GetMouseButtonDown(0)){
        //    Pecka.Create(poziceStrelby, UtilsClass.GetMouseWorldPosition());
            
        //}
        GameObject PeckaGO = (GameObject) Instantiate(pfPecka, poziceStrelby.position, poziceStrelby.rotation);
        Pecka pecka = PeckaGO.GetComponent<Pecka>();
        if(pecka != null)pecka.nastavCil(cil);
    }

}
