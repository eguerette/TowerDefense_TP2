using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchScenes : MonoBehaviour
{
    [SerializeField] private InfosNiveau _info;

    void Start() {

        _info.Goal1Destroyed = false;
        _info.Goal2Destroyed = false;
        _info.Coins = 0;
    }

    void Update() {

        DeathLvl1();
        DeathLvl2();
    }
    
    public void Intro() {

        SceneManager.LoadScene(0);
    }
    
    public void Niveau1() {

        SceneManager.LoadScene(1);
    }

    public void Niveau2() {
        
        SceneManager.LoadScene(2);
    }

    public void End() {

        SceneManager.LoadScene(3);
    }

    private void DeathLvl1() {

        if (_info.Goal1Destroyed == true) {

            SceneManager.LoadScene(2);
        }
    }

    private void DeathLvl2() {

        if (_info.Goal2Destroyed == true) {

            SceneManager.LoadScene(3);
        }
    }
}
