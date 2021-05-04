using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pecka : MonoBehaviour
{
    private Transform cil;
    private int damage;

    public void nastavCil(Transform _cil, int _damage)
    {
        cil = _cil;
        damage = _damage;
    }   

   
    private float speed = 20f;

    private void Update()
    {

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
