using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class N1_Turret3 : MonoBehaviour
{
     [SerializeField] private TurretInfo _infoTurret;
    [SerializeField] private GameObject target;

    [SerializeField] private GameObject turretHead;
    [SerializeField] private GameObject bulletSpawnPoint;
    [SerializeField] private GameObject bullet;
    [SerializeField] private GameObject defaultAnglePoint;
    private bool targetLocked;
    private bool shot = false;
    private float shotCooldown;

    void Start() {

        shotCooldown = _infoTurret.fireRateCooldown3;
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

    private void Shoot() {

        Transform _bullet = Instantiate(bullet.transform, bulletSpawnPoint.transform.position, quaternion.identity);
        _bullet.transform.rotation = bulletSpawnPoint.transform.rotation;

        shotCooldown = _infoTurret.fireRateCooldown1;
        shot = true;
        StartCoroutine(ShootingDelay());
    }

    private IEnumerator ShootingDelay() {

        yield return new WaitForSeconds(shotCooldown);
        shot = false;
    }

    // triggers

    private void OnTriggerEnter(Collider other) {

        if (other.tag == "Enemy" || other.tag == "Enemy2" || other.tag == "Enemy3" && !targetLocked) {

            target = other.gameObject;
            targetLocked = true;
        }
    }

    private void OnTriggerExit(Collider other) {

        if (other.tag == "Enemy" || other.tag == "Enemy2" || other.tag == "Enemy3") {

            target = null;
            targetLocked = false;
        }
    }
}
