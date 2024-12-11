using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class N1_Bullet2 : MonoBehaviour
{
    [SerializeField] private float bulletSpeed;
    [SerializeField] private float lifeTime = 10f;
    public GameObject turret;

    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * bulletSpeed);
        Destroy(gameObject, lifeTime);
    }

    void OnTriggerEnter(Collider other) {

        if (other.tag == "Enemy" || other.tag == "Enemy2" || other.tag == "Enemy3") {

            Destroy(gameObject);
        }
    }
}
