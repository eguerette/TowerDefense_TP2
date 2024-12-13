using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnapLocation : MonoBehaviour
{
    public Transform spotTransform;

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Turret"))
        {
            other.transform.parent = transform;
            other.transform.position = spotTransform.transform.position;

            other.tag = "PlacedTurret";
            Debug.Log("Le tag a changé!");
        }   

        if (other.CompareTag("Turret2"))
        {
            other.transform.parent = transform;
            other.transform.position = spotTransform.transform.position;

            other.tag = "PlacedTurret";
            Debug.Log("Le tag a changé!");
        } 

        if (other.CompareTag("Turret3"))
        {
            other.transform.parent = transform;
            other.transform.position = spotTransform.transform.position;

            other.tag = "PlacedTurret";
            Debug.Log("Le tag a changé!");
        } 
    }
}
