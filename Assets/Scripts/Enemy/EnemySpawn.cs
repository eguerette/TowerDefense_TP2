using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{   
    public GameObject enemy;
    public GameObject enemySpawnPoint;
    public Transform Goal;
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

        Transform _enemy = Instantiate(enemy.transform, enemySpawnPoint.transform.position, quaternion.identity);
        _enemy.transform.rotation = enemySpawnPoint.transform.rotation;

        spawnCooldown = spawnCooldownReset;
        spawned = true;
        StartCoroutine(SpawnRate());

    }

    private IEnumerator SpawnRate() {

        yield return new WaitForSeconds(spawnCooldown);
        spawned = false;

    }
}
