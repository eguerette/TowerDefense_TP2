using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Goal : MonoBehaviour
{   
    private void OnTriggerEnter(Collider other) {

        if (other.tag == "Enemy" || other.tag == "Enemy2" || other.tag == "Enemy3") {

            Destroy(gameObject);
        }
    }
}
