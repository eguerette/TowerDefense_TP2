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
        if (other.CompareTag("Turret"))
        {
            if (spotMaterial != null)
            {
                spotMaterial.material.color = Color.green;
            }

<<<<<<<< HEAD:Assets/Scripts/SpotManager.cs
            other.transform.SetParent(spotTransform);
            if (other.CompareTag("TurretBody") && other.CompareTag("Turret"))
========
    public void OnTriggerExit(Collider other) 
    {
        if (other.CompareTag("Turret"))
        {
            if (spotMaterial != null)
>>>>>>>> parent of a8e6f77 (Fixed turret placement):Assets/Scripts/SpotColor.cs
            {
                other.transform.SetParent(spotTransform);
            }
        }
    }
}
