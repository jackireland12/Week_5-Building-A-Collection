using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerClass : MonoBehaviour
{
    public List<GameObject> enemies = new List<GameObject>();
    public GameObject enemie1;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            spawnEnemie();
        }
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            deleteEnemie();
        }
        CleanEnemyList();
        
    }

    void spawnEnemie()
    {
        Vector3 randomspawn = new Vector3(5.0f, Random.Range(-5.0f, 5.0f), 0f);
        GameObject enemy = Instantiate(enemie1, randomspawn,Quaternion.identity);
        enemies.Add(enemy);

    }
    void deleteEnemie()
    {
        GameObject enemyToDelete = enemies[0];
        enemies.RemoveAt(0);
        Destroy(enemyToDelete);
        Debug.Log("del");

    }
    void CleanEnemyList()
    {
        for (int i = enemies.Count - 1; i >= 0; i--) // Loop backwards to avoid index issues
        {
            if (enemies[i] == null) // Only remove if destroyed
            {
                enemies.RemoveAt(i);
                Debug.Log("cleen list");
            }
        }
    }
}