using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public EnemyInfo _info;
    public Transform _Goal;
    public float mvtSpeed = 2;
    private Turret _turretScript;
    private float enemyLife1;

  
    private void Start()
    {
        enemyLife1 = _info.lifev1;
    }

    void Update()
    {
        
        transform.LookAt(_Goal);
        transform.position += transform.forward * mvtSpeed * Time.deltaTime;
    }

    private async void OnTriggerEnter(Collider other) {

        if (other.tag == "Projectile") {
            
            if (enemyLife1 > 0) {

                enemyLife1 --;
            }
            else {
                
                Destroy(gameObject);
            }
            
        }
    }
    
}
