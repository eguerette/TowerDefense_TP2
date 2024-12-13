using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Turret", menuName = "ScriptableObjects/TurretInfo")]

public class TurretInfo : ScriptableObject
{
    public float fireRateCooldown1 = 1f;
    public float fireRateCooldown2 = 2f;
    public float fireRateCooldown3 = 3f;
    public bool turret1;
    public bool turret2;
    public bool turret3;
    public float valueTurret1;
    public float valueTurret2;
    public float valueTurret3;
}
