using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Niveau", menuName = "ScriptableObjects/NiveauInfo")]
public class InfosNiveau : ScriptableObject
{
    public float temps;
    public float tempsInitial;
    public float Coins;
    public bool Goal1Destroyed;
    public bool Goal2Destroyed;
}