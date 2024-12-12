using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class N1_Enemy1 : MonoBehaviour
{
    [SerializeField] private EnemyInfo _info;
    [SerializeField] private InfosNiveau _infoNiveau;
    [SerializeField] private Animator _animationController;
    private float mvtSpeed;
    private float enemylife;

    void Start() {

        enemylife = _info.life1;
        mvtSpeed = _info.speed1;
    }

    void Update() {
        if (enemylife > 0) {

            Move();
        }
        
    }

    private void Move() {

        transform.position += transform.forward * mvtSpeed * Time.deltaTime;
    }

    //Triggers

    private void OnTriggerEnter(Collider other) {

        if (other.tag == "Projectile") {

            if (enemylife > 0) {

                enemylife --;
            }

            else {

                _infoNiveau.Coins += 5;
                StartCoroutine(DestroyAfterDelay());
                _animationController.SetBool("Dead", true);
            }

        }

        if (other.tag == "Goal") {

            _infoNiveau.Goal1Destroyed = true;
        }

        if (other.tag == "Goal2") {

            _infoNiveau.Goal2Destroyed = true;
        }
    }

    private IEnumerator DestroyAfterDelay() {

        yield return new WaitForSeconds(0.5f);
        Destroy(gameObject);
    }
}
