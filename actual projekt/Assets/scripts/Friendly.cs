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
    public int shootDelay;
    public int startShootDelay;
    private int counter;
    
    private float rotace;
    public GameObject pfPecka;
    public Transform poziceStrelby;
    public Transform tresen;
    private string nazevNepritele = "Nepritel";
    private bool staloSe = false;

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
        if(nejkratsiVzdalenost > range)cil = null;
        
    }
    void Start()
    {
        startShootDelay = shootDelay;
        //InvokeRepeating("upravCil", 0f, 0.5f);
    }
    
    void Update()
    {
        if(Spawner.doubleS == true && staloSe == false)
        {
            shootDelay = shootDelay/2;
            staloSe = true;
        }
        else shootDelay = startShootDelay;
        if(Spawner.doubleS == false && staloSe == true)staloSe = false;
        upravCil();
        counter++;
        if(counter >= shootDelay)
        {
            Utok();
            counter = 0;
        }
        
        if(cil != null)
        {
        Vector3 dir = cil.position - transform.position;     
        transform.rotation = Quaternion.LookRotation(Vector3.forward, dir);
        }
    }

    private void Utok()
    {
        
        //if(Input.GetMouseButtonDown(0)){
        //    Pecka.Create(poziceStrelby, UtilsClass.GetMouseWorldPosition());
            
        //}
        if(cil != null){
        GameObject PeckaGO = (GameObject) Instantiate(pfPecka, poziceStrelby.position, poziceStrelby.rotation);
        Pecka pecka = PeckaGO.GetComponent<Pecka>();
        if(pecka != null)pecka.nastavCil(cil, damage);
        }
    }

    void OnDrawGizmosSelected ()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(transform.position, range); 
    }
}
