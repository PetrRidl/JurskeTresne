using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CodeMonkey;
using CodeMonkey.Utils;

public class Friendly : MonoBehaviour
{
    private Transform cil;
    public int damage;
    public float range = 1f;
    private int counter;
    public int shootDelay = 200;
    private float rotace;
    public GameObject pfPecka;
    public Transform poziceStrelby;
    public Transform tresen;
    private string nazevNepritele = "Nepritel";

    void upravCil()
    {
        GameObject[] nepratele = GameObject.FindGameObjectsWithTag(nazevNepritele);
        float nejkratsiVzdalenost = Mathf.Infinity; 
        GameObject nejblizsi = null;
        foreach(GameObject duch in nepratele)
        {
            float vzdalenost = Vector3.Distance (transform.position, duch.transform.position);
            if(vzdalenost < nejkratsiVzdalenost)
            {
                nejkratsiVzdalenost = vzdalenost;
                nejblizsi = duch;
            }
        }
        if(nejblizsi != null && nejkratsiVzdalenost <= range)
        {
            cil = nejblizsi.transform;
        }
        
    }
    void Start()
    {
        //InvokeRepeating("upravCil", 0f, 0.5f);
    }
    
    void Update()
    {
        upravCil();
        counter++;
        if(counter >= shootDelay)
        {
            Utok();
            counter = 0;
        }
        
        
        Vector3 dir = cil.position - transform.position;
        Quaternion lookRotation = Quaternion.LookRotation(dir);
        Vector3 rotation = lookRotation.eulerAngles;
        transform.rotation = Quaternion.Euler(0f, 0f, 0f); 

    }

    private void Utok()
    {
        
        //if(Input.GetMouseButtonDown(0)){
        //    Pecka.Create(poziceStrelby, UtilsClass.GetMouseWorldPosition());
            
        //}
        GameObject PeckaGO = (GameObject) Instantiate(pfPecka, poziceStrelby.position, poziceStrelby.rotation);
        Pecka pecka = PeckaGO.GetComponent<Pecka>();
        if(pecka != null)pecka.nastavCil(cil, damage);
    }

    void OnDrawGizmosSelected ()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(transform.position, range); 
    }
}
