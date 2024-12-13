using UnityEngine;

public class TurretManager : MonoBehaviour
{
    public Collider sphereCollider;

    void Start()
    {
        if (sphereCollider != null)
        {
            sphereCollider.enabled = false;
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("TurretSpot"))
        {
            sphereCollider.enabled = true;
            gameObject.tag = "PlacedTurret";
        }
    }
}