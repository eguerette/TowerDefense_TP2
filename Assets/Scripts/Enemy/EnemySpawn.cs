using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{   
    public GameObject ennemy;
    public GameObject ennemySpawnPoint;

    private float timer = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if(timer == 10f) {

            Spawn();
            timer = 0.0f;
        }
    }

    private void Spawn() {

        Transform _ennemy = Instantiate(ennemy.transform, ennemySpawnPoint.transform.position, quaternion.identity);
        _ennemy.transform.rotation = ennemySpawnPoint.transform.rotation;
    }
}
