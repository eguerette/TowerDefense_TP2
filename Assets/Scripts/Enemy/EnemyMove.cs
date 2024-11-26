using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    private Transform _Goal;
    private Turret _turretScript;
    private EnemyInfo _enemyInfoScript;
    public float mvtSpeed = 2;

    void Start() {

        _Goal = _enemyInfoScript.Goal;
    }
    // Update is called once per frame
    void Update()
    {
        
        transform.LookAt(_Goal);
        transform.position += transform.forward * mvtSpeed * Time.deltaTime;
    }

    private void OnTriggerEnter(Collider other) {

        if (other.tag == "Projectile") {

            Destroy(gameObject);
            _turretScript.target = null;
        }
    }
    
}
