using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretUISpawner : MonoBehaviour
{
    public Transform handTransform; // Reference to the player's hand
    public GameObject[] turretPrefabs; // Array to store turret prefabs

    public void SpawnTurret(int turretIndex)
    {
        if (turretIndex >= 0 && turretIndex < turretPrefabs.Length)
        {
            // Destroy any existing object in hand (optional)
            foreach (Transform child in handTransform)
            {
                Destroy(child.gameObject);
            }

            // Instantiate the selected turret prefab
            GameObject spawnedTurret = Instantiate(turretPrefabs[turretIndex], handTransform.position, handTransform.rotation);
            
            // Optionally, parent the turret to the hand
            spawnedTurret.transform.SetParent(handTransform);
        }
        else
        {
            Debug.LogWarning("Invalid turret index.");
        }
    }
}
