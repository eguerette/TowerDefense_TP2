using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnnemyMoveTests : MonoBehaviour
{
    public GameObject ennemy;
    public float mvtSpeed = 2;
    // Start is called before the first frame update
    void Start()
    {
        ennemy.transform.position = new Vector3(1,7,16);
    }

    // Update is called once per frame
    void Update()
    {
        ennemy.transform.position += Vector3.back * Time.deltaTime * mvtSpeed;
    }
}
