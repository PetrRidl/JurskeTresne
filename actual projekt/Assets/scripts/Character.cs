using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;


public class Character : MonoBehaviour
{
    public float speed;
    
    public int maxHP;
    private Waypoints Wpoints;
    private int waypointIndex;
    private int myHP;
    public int damageDo;
    public static int damageGot;
    public int killIncome;
    
    
    void Start()
    {
        Wpoints = GameObject.FindGameObjectWithTag("Waypoints").GetComponent<Waypoints>();
        myHP = maxHP;
    }
    void Update()
    {
        if(damageGot != null){
            myHP -= damageGot;
            damageGot = 0;
        }   
        transform.position = Vector2.MoveTowards(transform.position, Wpoints.waypoints[waypointIndex].position, speed * Time.deltaTime);
        
        Vector3 smer = Wpoints.waypoints[waypointIndex].position - transform.position;
        float uhel = Mathf.Atan2(smer.y, smer.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(uhel, Vector3.forward);
    
       
        if(Vector2.Distance(transform.position, Wpoints.waypoints[waypointIndex].position) < 0.1f) 
        {
            if (waypointIndex < Wpoints.waypoints.Length - 1) waypointIndex++;
            else
            {
                Destroy(gameObject);
                Spawner.zivoty -= damageDo;
            } 
        }
        if(myHP<= 0)
        {
            Destroy(gameObject);
            Spawner.penize += killIncome;
            

        }

        
    }
    public static void getDamage(int damage)
    {
        damageGot = damage;
        
    }

}
