using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCameraView : MonoBehaviour
{
    public Transform playerCamera;
    public Vector3 offset = new Vector3(1, 0, 1);
    
    void Update()
    {
        transform.position = playerCamera.position + playerCamera.forward * offset.z 
                           + playerCamera.right * offset.x 
                           + playerCamera.up * offset.y;

        transform.rotation = Quaternion.LookRotation(transform.position - playerCamera.position);
    }
}
