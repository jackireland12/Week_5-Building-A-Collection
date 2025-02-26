using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerClass : MonoBehaviour
{
    public GameObject target;
    private SpawnerClass ec;
    private void Start()
    {
        ec = FindObjectOfType<SpawnerClass>();
    }
    private void Update()
    {
        if (ec.enemies != null)
        {
            findClosestEnemy();
        }
    }
     
    void findClosestEnemy()
    {
        float closestDistance = Mathf.Infinity;
        GameObject closestEnemy= null;
        foreach( GameObject enemy in ec.enemies )
        {
            float distance = Vector3.Distance(transform.position,enemy.transform.position);
            if (distance < closestDistance)
            {
                closestDistance = distance;
                closestEnemy = enemy;
            }
        }
        target = closestEnemy;
        Debug.Log(target);
    }
}
