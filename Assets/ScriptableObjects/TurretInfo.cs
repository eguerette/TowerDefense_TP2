using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Turret", menuName = "ScriptableObjects/TurretInfo")]

public class TurretInfo : ScriptableObject
{
    public float bulletSpeed1 = 1;
    public float bulletSpeed2 = 1;
    public float bulletSpeed3 = 1;
    public bool turret1;
    public bool turret2;
    public bool turret3;
}
