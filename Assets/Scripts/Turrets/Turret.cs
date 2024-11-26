using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class Turret : MonoBehaviour
{
    
    private GameObject target;
    private bool targetLocked;
    

    public GameObject turretHead;
    public GameObject bulletSpawnPoint;
    public GameObject bullet;
    public bool targetDestroyed = false;
    
    
    void Update() {
        
        //shooting and detecting ennemies
        if (targetLocked && targetDestroyed == false) {

            turretHead.transform.LookAt(target.transform);

            Shoot();
        }
    }

    private void OnTriggerEnter(Collider other) {

        if(other.tag == "Enemy") {
            target = other.gameObject;
            targetLocked = true;
        }
    }
    private void OnTriggerExit(Collider other) {

        if(other.tag == "Enemy") {
            target = null;
            targetLocked = false;
        }
    }


    private void Shoot() {

        Transform _bullet = Instantiate(bullet.transform, bulletSpawnPoint.transform.position, quaternion.identity);
        _bullet.transform.rotation = bulletSpawnPoint.transform.rotation;
    }

}
