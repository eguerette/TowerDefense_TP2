using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public GameObject enemy;
    private GameObject Goal;
    public Transform _Goal;
    public float mvtSpeed = 2;
    private Turret _turretScript;

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(_Goal);
        transform.position += transform.forward * mvtSpeed * Time.deltaTime;
    }

    private void OnTriggerEnter(Collider other) {

        if (other.tag == "Projectile") {

            Destroy(enemy);
            _turretScript.targetDestroyed = true;
        }
    }
    
}
