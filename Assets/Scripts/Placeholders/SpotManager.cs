using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpotManager : MonoBehaviour
{
    private Renderer spotMaterial;

    public Transform spotTransform;

    void Start()
    {
        spotMaterial = GetComponent<Renderer>();
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("TurretBody"))
        {
            if (spotMaterial != null)
            {
                spotMaterial.material.color = Color.green;
            }

            other.transform.SetParent(spotTransform);
            if (other.CompareTag("TurretBody") && other.CompareTag("Turret"))
            {
                other.transform.SetParent(spotTransform);
            }
        }
    }
}
