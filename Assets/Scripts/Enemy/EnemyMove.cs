using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public Transform _Goal;
    private Turret _turretScript;
    public float mvtSpeed = 2;
    void Update()
    {
        
        transform.LookAt(_Goal);
        transform.position += transform.forward * mvtSpeed * Time.deltaTime;
    }

    private async void OnTriggerEnter(Collider other) {

        if (other.tag == "Projectile") {

            Destroy(gameObject);
        }
    }
    
}
