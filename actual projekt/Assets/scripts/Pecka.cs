using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pecka : MonoBehaviour
{
    private Transform cil;
    private int damage;
    private bool staloSe = false;
    public void nastavCil(Transform _cil, int _damage)
    {
        cil = _cil;
        damage = _damage;
    }   

   
    private int speed = 30;
    private int startSpeed;
    void Start()
    {
        startSpeed = speed;
    }
    private void Update()
    {
        if(Spawner.doubleS == true && staloSe == false)
        {
            speed = speed * 2;
            staloSe = true;
        }
        else speed = startSpeed;
        if(Spawner.doubleS == false && staloSe == true)staloSe = false;
        if(cil == null)
        {
            Destroy(gameObject);
            return;
        }
        Vector3 dir = cil.position - transform.position;
        float distanceThisFrame = speed * Time.deltaTime;
        if(dir.magnitude <= distanceThisFrame)
        {
            HitTarget();
            return;
        }
        transform.Translate (dir.normalized * distanceThisFrame, Space.World);
    }
     void HitTarget()
    {
        Destroy(gameObject);
        Character.getDamage(damage);
    }
}
