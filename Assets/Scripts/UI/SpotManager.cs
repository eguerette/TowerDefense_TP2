using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpotManager : MonoBehaviour
{
    private Renderer spotMaterial;

    public Collider sphereCollider;
    public Collider sphereCollider2;
    public Collider sphereCollider3;
    public Transform spotTransform;

    void Start()
    {
        spotMaterial = GetComponent<Renderer>();
    }

    public void OnTriggerEnter(Collider other)
    {
        if ((other.tag == "Turret"))
        {
            if (spotMaterial != null)
            {
                spotMaterial.material.color = Color.green;
            }

            other.transform.parent = transform;
            other.transform.position = spotTransform.position;

            sphereCollider.enabled = true;
        }
        if ((other.tag == "Turret2"))
        {
            if (spotMaterial != null)
            {
                spotMaterial.material.color = Color.green;
            }

            other.transform.parent = transform;
            other.transform.position = spotTransform.position;

            sphereCollider2.enabled = true;
        } 
        if ((other.tag == "Turret3"))
        {
            if (spotMaterial != null)
            {
                spotMaterial.material.color = Color.green;
            }

            other.transform.parent = transform;
            other.transform.position = spotTransform.position;

            sphereCollider3.enabled = true;
        }    
        else 
        {
            Debug.Log("Ceci n'est pas une tourelle");
        }
    }
}
