using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{   
    public GameObject enemy;
    public GameObject enemySpawnPoint;

    private float timer = 0f;
    private Turret _turretScript;
    void Update()
    {

        timer += Time.deltaTime;

        if(timer == 5f) {

            Spawn();
            timer = 0f;
            _turretScript.targetDestroyed = false;
        }
    }

    private void Spawn() {

        Transform _enemy = Instantiate(enemy.transform, enemySpawnPoint.transform.position, quaternion.identity);
        _enemy.transform.rotation = enemySpawnPoint.transform.rotation;
    }
}
