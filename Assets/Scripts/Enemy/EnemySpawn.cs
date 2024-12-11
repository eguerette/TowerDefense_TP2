// using System;
// using System.Collections;
// using System.Collections.Generic;
// using Unity.Mathematics;
// using Unity.VisualScripting;
// using UnityEngine;

// public class EnemySpawn : MonoBehaviour
// {   
//     public GameObject enemy;
//     public GameObject enemy1;
//     public GameObject enemy2;
//     public GameObject enemySpawnPoint;
//     public Transform Goal;
//     public InfosNiveau _infoNiveau;
//     private bool spawned = false;
//     private float spawnCooldown = 10f;
//     private float spawnCooldownReset = 10f;
    

//     void Start() {

//         gameObject.transform.LookAt(Goal.position);
//     }

//     void Update()
//     {   
//         if(spawned == false) {

//             SpawnLvl1();
//         }
//     }

//     private void SpawnLvl1() {

//         Transform _enemy = Instantiate(enemy.transform, enemySpawnPoint.transform.position, quaternion.identity);
//         _enemy.transform.rotation = enemySpawnPoint.transform.rotation;
        
//         spawnCooldown = spawnCooldownReset;
//         spawned = true;

//         StartCoroutine(SpawnRate());
//     }

//     private IEnumerator SpawnRate() {

//         yield return new WaitForSeconds(spawnCooldown);
//         spawned = false;

//     }

// }
using System.Collections;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GameObject enemy;
    public GameObject enemy1;
    public GameObject enemy2;
    public GameObject enemySpawnPoint;
    private Transform Goal;
    public InfosNiveau _infoNiveau;

    private bool spawned = false;
    private float spawnCooldown = 10f;
    private float spawnCooldownReset = 10f;

    private Goal goalInfo;

    void Start()
    {
        Goal = goalInfo._goal;

        gameObject.transform.LookAt(Goal.position);

        StartCoroutine(SpawnEnemy1AfterDelay(25f));
        StartCoroutine(SpawnEnemy1AfterDelay(50f));
        StartCoroutine(SpawnEnemy1AfterDelay(75f));
        StartCoroutine(SpawnEnemy1AfterDelay(100f));


        StartCoroutine(SpawnEnemy2AfterDelay(60f));
        StartCoroutine(SpawnEnemy2AfterDelay(110f));
    }

    void Update()
    {
        if (!spawned)
        {
            SpawnLvl1();
        }
    }

    private void SpawnLvl1()
    {
        Transform _enemy = Instantiate(enemy.transform, enemySpawnPoint.transform.position, Quaternion.identity);
        _enemy.transform.rotation = enemySpawnPoint.transform.rotation;

        spawnCooldown = spawnCooldownReset;
        spawned = true;

        StartCoroutine(SpawnRate());
    }

    private IEnumerator SpawnRate()
    {
        yield return new WaitForSeconds(spawnCooldown);
        spawned = false;
    }

    private IEnumerator SpawnEnemy1AfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        Instantiate(enemy1, enemySpawnPoint.transform.position, Quaternion.identity).transform.rotation = enemySpawnPoint.transform.rotation;
    }

    private IEnumerator SpawnEnemy2AfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        Instantiate(enemy2, enemySpawnPoint.transform.position, Quaternion.identity).transform.rotation = enemySpawnPoint.transform.rotation;
    }
}
