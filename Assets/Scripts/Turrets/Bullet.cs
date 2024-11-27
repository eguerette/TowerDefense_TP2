using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{   
    public float bulletSpeed = 200;
    public float lifeTime = 1;
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * bulletSpeed);
        Destroy(gameObject, lifeTime);
    }
}
