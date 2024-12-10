using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEditor.ShaderGraph.Internal;
using UnityEngine;

public class Bullet : MonoBehaviour
{   
    public float bulletSpeed;
    public float lifeTime = 1;
    public GameObject turret;

    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * bulletSpeed);
        Destroy(gameObject, lifeTime);
    }

    void OnTriggerEnter(Collider other) {

        if (other.tag == "Enemy") {

            Destroy(gameObject);
        }
    }
}
