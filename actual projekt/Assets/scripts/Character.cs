using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

public class Character : MonoBehaviour
{
    public float speed;
    private Waypoints Wpoints;
    private int waypointIndex;
    void Start()
    {
        Wpoints = GameObject.FindGameObjectWithTag("Waypoints").GetComponent<Waypoints>();
    }
    void Update()
    {
        Vector3 smer = Wpoints.waypoints[waypointIndex].position - transform.position;
        float uhel = Mathf.Atan2(smer.y, smer.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(uhel, Vector3.forward);
    
        transform.position = Vector2.MoveTowards(transform.position, Wpoints.waypoints[waypointIndex].position, speed * Time.deltaTime);
        if(Vector2.Distance(transform.position, Wpoints.waypoints[waypointIndex].position) < 0.1f) 
        {
            if (waypointIndex < Wpoints.waypoints.Length - 1) waypointIndex++;
            else Destroy(gameObject);
        }
    }
}
