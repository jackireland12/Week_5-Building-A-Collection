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
    }

    void spawnEnemie()
    {
        GameObject enemy = Instantiate(enemie1);
        enemies.Add(enemy);

    }
}