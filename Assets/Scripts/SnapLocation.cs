using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnapLocation : MonoBehaviour
{
    public Transform spotTransform;
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private AudioClip soundEffect;


    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Turret"))
        {
            other.transform.parent = transform;
            other.transform.position = spotTransform.transform.position;

            other.tag = "PlacedTurret";
            Debug.Log("Le tag a changé!");
            audioSource.PlayOneShot(soundEffect);
        }   

        if (other.CompareTag("Turret2"))
        {
            other.transform.parent = transform;
            other.transform.position = spotTransform.transform.position;

            other.tag = "PlacedTurret";
            Debug.Log("Le tag a changé!");
            audioSource.PlayOneShot(soundEffect);
        } 

        if (other.CompareTag("Turret3"))
        {
            other.transform.parent = transform;
            other.transform.position = spotTransform.transform.position;

            other.tag = "PlacedTurret";
            Debug.Log("Le tag a changé!");
            audioSource.PlayOneShot(soundEffect);
        } 
    }
}
