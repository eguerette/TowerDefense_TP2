using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    //public GameObject ennemy;
    private GameObject Goal;
    public Transform _Goal;
    public float mvtSpeed = 2;

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(_Goal);
        transform.position += transform.forward * mvtSpeed * Time.deltaTime;
    }

    
}
