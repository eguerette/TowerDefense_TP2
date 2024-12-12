using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{   
    private InfosNiveau _info;
    
    private void OnTriggerEnter(Collider other) {

        if (other.tag == "Enemy" || other.tag == "Enemy2" || other.tag == "Enemy3") {

            _info.Goal1Destroyed = true;
            Destroy(gameObject);
        }
    }
}
