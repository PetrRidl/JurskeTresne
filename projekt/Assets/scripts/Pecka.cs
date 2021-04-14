using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pecka : MonoBehaviour
{
    private Transform cil;

    public void nastavCil(Transform _cil)
    {
        cil = _cil;
    }   
    public static void Create(Vector3 spawnPosition, Vector3 targetPosition)
    {
        Transform peckaTransform = Instantiate(GameAssets.i.pfPecka, spawnPosition, Quaternion.identity);

        Pecka projektilPecky =  peckaTransform.GetComponent<Pecka>();
        projektilPecky.Setup(targetPosition);  
    }
    private Vector3 targetPosition;
    private float speed = 20f;
    private void Setup(Vector3 targetPosition)
    {
        this.targetPosition = targetPosition;
    }
    private void Update()
    {
        //Vector3 moveDir = (targetPosition - transform.position).normalized;
        
        
        //float ZnicSe = 1f;
        //if(Vector3.Distance(transform.position, targetPosition) < ZnicSe)
        //{
        //   Destroy(gameObject);
        //}
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
    }
}
