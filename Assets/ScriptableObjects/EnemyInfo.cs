using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Enemy", menuName = "ScriptableObjects/EnemyInfo")]
public class EnemyInfo : ScriptableObject
{
    public float life1 = 5f;
    public float life2 = 10f;
    public float life3 = 15f;
    public float speed1 = 15f;
    public float speed2 = 10f;
    public float speed3 = 5f;
    public bool enemy1 = false;
    public bool enemy2 = false;
    public bool enemy3 = false;
}
