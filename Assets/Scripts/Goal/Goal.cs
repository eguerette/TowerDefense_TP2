using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public GameObject _goal;
    private void OnTriggerEnter(Collider other) {

        if (other.tag == "Enemy") {

            Destroy(_goal);
        }
    }
}
