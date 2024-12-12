using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class PointAffichageFin : MonoBehaviour
{
    [SerializeField] private InfosNiveau _info;
    [SerializeField] private TMP_Text points;

    void Start() {

        points.text = "Score: " + _info.Points;
    }
}
