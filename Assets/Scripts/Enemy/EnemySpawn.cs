using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{   
    public GameObject enemy;
    public GameObject enemy1;
    public GameObject enemy2;
    public GameObject enemySpawnPoint;
    public Transform Goal;
    public InfosNiveau _infoNiveau;
    private bool spawned = false;
    private float spawnCooldown = 10f;
    private float spawnCooldownReset = 10f;
    

    void Start() {

        gameObject.transform.LookAt(Goal.position);
    }

    void Update()
    {   
        if(spawned == false) {

            Spawn();
        }
    }

    private void Spawn() {

        if (_infoNiveau.temps <=30 && _infoNiveau.temps > 15) {

            Transform _enemy = Instantiate(enemy.transform, enemySpawnPoint.transform.position, quaternion.identity);
            _enemy.transform.rotation = enemySpawnPoint.transform.rotation;
        }
        
        if (_infoNiveau.temps <= 15 && _infoNiveau.temps > 5) {

            Transform _enemy1 = Instantiate(enemy1.transform, enemySpawnPoint.transform.position, quaternion.identity);
            _enemy1.transform.rotation = enemySpawnPoint.transform.rotation;
        }

        if (_infoNiveau.temps < 5) {

            Transform _enemy2 = Instantiate(enemy2.transform, enemySpawnPoint.transform.position, quaternion.identity);
            _enemy2.transform.rotation = enemySpawnPoint.transform.rotation;
        }

        spawnCooldown = spawnCooldownReset;
        spawned = true;

        StartCoroutine(SpawnRate());

    }

    private IEnumerator SpawnRate() {

        yield return new WaitForSeconds(spawnCooldown);
        spawned = false;

    }

}
