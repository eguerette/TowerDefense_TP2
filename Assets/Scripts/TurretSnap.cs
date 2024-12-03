using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretSnap : MonoBehaviour
{

    private Vector3 originalPosition;

    private Transform closestSpot;

    // Start is called before the first frame update
    void Start()
    {
        originalPosition = transform.position;
    }

    public void OnTriggerEnter(Collider other) 
    {
        if (other.CompareTag("TurretSpot"))
        {
            closestSpot = other.transform;
        }
    }

    public void OnTriggerExit(Collider other) 
    {
        if (other.CompareTag("TurretSpot"))
        {
            closestSpot = null;
        }
    }

    public void OnRelease()
    {
        if (closestSpot != null) 
        {
            transform.position = closestSpot.position;

            GetComponent<Collider>().enabled = false;
        }
        else
        {
            transform.position = originalPosition;
        }
    }
}
