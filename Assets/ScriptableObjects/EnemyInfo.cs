using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Enemy", menuName = "ScriptableObjects/EnemyInfo")]
public class EnemyInfo : ScriptableObject
{
    public float life1 = 50f;
    public float life2 = 5f;
    public float life3 = 250f;
    public float speed1 = 10f;
    public float speed2 = 20f;
    public float speed3 = 5f;
    public bool enemy1 = false;
    public bool enemy2 = false;
    public bool enemy3 = false;
}
