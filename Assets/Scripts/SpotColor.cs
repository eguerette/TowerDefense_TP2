using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpotColor : MonoBehaviour
{

    private Renderer spotMaterial;

    // Start is called before the first frame update
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
        }
    }

    public void OnTriggerExit(Collider other) 
    {
        if (other.CompareTag("Turret"))
        {
            if (spotMaterial != null)
            {
                spotMaterial.material.color = Color.red;
            }
        }
    }
}
