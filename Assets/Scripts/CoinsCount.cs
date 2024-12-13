using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class CoinsCount : MonoBehaviour

{
    [SerializeField] private InfosNiveau _infosNiveau;

    [SerializeField] private TMP_Text coinsCountText;


    void Start() 
    {
        resetCoins();
    }
    
    void Update() 
    {
        coinsCountText.text = _infosNiveau.Coins.ToString();
    }

    void resetCoins() 
    {
        _infosNiveau.Coins = _infosNiveau.coinsInitial;
    }
}