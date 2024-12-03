using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using Unity.VisualScripting;
using Unity.XR.CoreUtils;
using UnityEngine;

public class Turret : MonoBehaviour
{
    public TurretInfo _infoTurret;
    public GameObject target;
    private bool targetLocked;
    private bool shot = false;
    private float shotCooldown = 1f;
    private float shotCooldownReset;
    

    public GameObject turretHead;
    public GameObject bulletSpawnPoint;
    public GameObject bullet;
    public GameObject defaultAnglePoint;
    
    void Start() {

        if (this.tag == "Turret") {

            shotCooldownReset = _infoTurret.fireRateCooldown1;
        }
        if (this.tag == "Turret2") {

            shotCooldownReset = _infoTurret.fireRateCooldown2;
        }
        if (this.tag == "Turret3") {

            shotCooldownReset = _infoTurret.fireRateCooldown3;
        }
    }

    void Update() {
        //shooting and detecting ennemies
        if (targetLocked && target != null) {

            turretHead.transform.LookAt(target.transform);

            if(shot == false) {

                Shoot();
            }
            
        }

        else {
            turretHead.transform.LookAt(defaultAnglePoint.transform);
        }
    }

    private void OnTriggerEnter(Collider other) {

        if(other.tag == "Enemy" || other.tag == "Enemy2" || other.tag == "Enemy3") {
            target = other.gameObject;
            targetLocked = true;
        }
    }
    private void OnTriggerExit(Collider other) {

        if(other.tag == "Enemy" || other.tag == "Enemy2" || other.tag == "Enemy3") {
            target = null;
            targetLocked = false;
        }
    }


    private void Shoot() {

        Transform _bullet = Instantiate(bullet.transform, bulletSpawnPoint.transform.position, quaternion.identity);
        _bullet.transform.rotation = bulletSpawnPoint.transform.rotation;
        
        shotCooldown = shotCooldownReset;
        shot = true;
        StartCoroutine(ResetShotState());
    }

    private IEnumerator ResetShotState() {

        yield return new WaitForSeconds(shotCooldown);
        shot = false;
    }
}
