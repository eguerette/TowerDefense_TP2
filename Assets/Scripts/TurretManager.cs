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

    public void ActivateCollider()
    {
        if (sphereCollider != null)
        {
            sphereCollider.enabled = true;
            gameObject.tag = "PlacedTurret";
        }
    }
}