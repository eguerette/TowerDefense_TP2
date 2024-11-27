using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Bullet : MonoBehaviour
{   
    public float bulletSpeed;
    public float lifeTime = 1;
    public TurretInfo _infoTurret;
    public GameObject turret;

    void Start() {

        if (turret.tag == "Turret") {

            bulletSpeed = _infoTurret.bulletSpeed1;
        }
        if (turret.tag == "Turret2") {

            bulletSpeed = _infoTurret.bulletSpeed2;
        }
        if (turret.tag == "Turret3") {

            bulletSpeed = _infoTurret.bulletSpeed3;
        }

    }
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * bulletSpeed);
        Destroy(gameObject, lifeTime);
    }
}
