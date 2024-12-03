using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Turret", menuName = "ScriptableObjects/TurretInfo")]

public class TurretInfo : ScriptableObject
{
    public float fireRateCooldown1 = 1;
    public float fireRateCooldown2 = 0.5f;
    public float fireRateCooldown3 = 0.05f;
    public bool turret1;
    public bool turret2;
    public bool turret3;
}
