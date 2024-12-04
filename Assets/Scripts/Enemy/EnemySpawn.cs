using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{   
    public GameObject enemy;
    public GameObject enemySpawnPoint;
    public Transform Goal;
    public InfosNiveau _infoNiveau;
    private Enemy _enemy;
    private bool spawned = false;
    private float spawnCooldown = 10f;
    private float spawnCooldownReset = 10f;
    string[] _enemies1 = {"Enemy", "Enemy1"};
    string[] _enemies2 = {"Enemy", "Enemy1", "Enemy2"};
    

    void Start() {

        gameObject.transform.LookAt(Goal.position);
    }

    void Update()
    {   

        if(_infoNiveau.temps <= 5) {

            _enemy._tag = "Enemy";
        }
        else if (_infoNiveau.temps > 5 && _infoNiveau.temps <= 10) {

            _enemy._tag = _enemies1[UnityEngine.Random.Range(0, _enemies1.Length)];
        }
        else if (_infoNiveau.temps > 10 && _infoNiveau.temps < 15) {

            _enemy._tag = _enemies2[UnityEngine.Random.Range(0, _enemies1.Length)];
        }

        // if(_infoNiveau.temps <= 100) {

        //     _enemy._tag = "Enemy";
        // }
        // else if (_infoNiveau.temps > 100 && _infoNiveau.temps <= 200) {

        //     _enemy._tag = _enemies1[UnityEngine.Random.Range(0, _enemies1.Length)];
        // }
        // else if (_infoNiveau.temps > 200 && _infoNiveau.temps < 300) {

        //     _enemy._tag = _enemies2[UnityEngine.Random.Range(0, _enemies1.Length)];
        // }

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
