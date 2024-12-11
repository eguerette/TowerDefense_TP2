using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretUISpawner : MonoBehaviour
{
    public GameObject[] turretPrefabs;
    public Transform spawnPoint;
    public Transform controllerTransform;

    public void SpawnTurret(int turretIndex)
    {
        if (turretIndex >= 0 && turretIndex < turretPrefabs.Length)
        {
            GameObject spawnedTurret = Instantiate(turretPrefabs[turretIndex], spawnPoint.position, spawnPoint.rotation);
            
            spawnedTurret.transform.SetParent(controllerTransform);

            spawnedTurret.transform.localPosition = Vector3.zero;
            spawnedTurret.transform.localRotation = Quaternion.identity;
        }
        else
        {
            Debug.LogWarning("Invalid turret index.");
        }
    }
}