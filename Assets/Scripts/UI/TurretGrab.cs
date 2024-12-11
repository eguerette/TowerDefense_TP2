using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Oculus.Interaction;

public class TurretGrab : MonoBehaviour
{
        [SerializeField] public GameObject[] turretPrefabs;
        [SerializeField] public Transform spawnPoint;
        [SerializeField] public Transform controllerTransform;

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
                Debug.LogWarning("Pas de tourelle à ce niveau du tableau");
            }
        }
}

