using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnapLocation : MonoBehaviour
{
    public Collider sphereCollider;
    public Collider sphereCollider2;
    public Collider sphereCollider3;
    public Transform spotTransform;

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Turret"))
        {
            other.transform.parent = transform;
            other.transform.position = spotTransform.transform.position;

            sphereCollider.enabled = true;
            other.tag = "PlacedTurret";
            Debug.Log("Le tag a changé!");
        }   

        if (other.CompareTag("Turret2"))
        {
            other.transform.parent = transform;
            other.transform.position = spotTransform.transform.position;

            sphereCollider2.enabled = true;
            other.tag = "PlacedTurret";
            Debug.Log("Le tag a changé!");
        } 

        if (other.CompareTag("Turret3"))
        {
            other.transform.parent = transform;
            other.transform.position = spotTransform.transform.position;

            sphereCollider3.enabled = true;
            other.tag = "PlacedTurret";
            Debug.Log("Le tag a changé!");
        } 
    }
}
