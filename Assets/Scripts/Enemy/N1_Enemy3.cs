using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class N1_Enemy3 : MonoBehaviour
{
    [SerializeField] private EnemyInfo _info;
    [SerializeField] private InfosNiveau _infoNiveau;
    [SerializeField] private Animator _animationController;
    private float mvtSpeed;
    private float enemylife;

    void Start() {

        enemylife = _info.life3;
        mvtSpeed = _info.speed3;
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

                _infoNiveau.Coins += 20;
                StartCoroutine(DestroyAfterDelay());
                _animationController.SetBool("Dead", true);
            }

        }
    }
    private IEnumerator DestroyAfterDelay() {

        yield return new WaitForSeconds(0.5f);
        Destroy(gameObject);
    }
}
