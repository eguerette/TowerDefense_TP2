using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class EnemyMove : MonoBehaviour
{
    public EnemyInfo _info;
    public Transform _Goal;
    public float mvtSpeed;
    private float enemylife;

  
    private void Start()
    {
        if (gameObject.tag == "Enemy") {

            enemylife = _info.life1;
            mvtSpeed = _info.speed1;
        }
        if (gameObject.tag == "Enemy2") {

            enemylife = _info.life2;
            mvtSpeed = _info.speed2;
        }
        if (gameObject.tag == "Enemy3") {

            enemylife = _info.life3;
            mvtSpeed = _info.speed3;
        }
        
    }

    void Update()
    {
        
        transform.LookAt(_Goal);
        transform.position += transform.forward * mvtSpeed * Time.deltaTime;
    }

    private void OnTriggerEnter(Collider other) {

        if (other.tag == "Projectile") {
            
            if (enemylife > 0) {

                enemylife --;
            }
            else {
                
                Destroy(gameObject);
            }
            
        }
    }
    
}
