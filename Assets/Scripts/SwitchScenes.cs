using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchScenes : MonoBehaviour
{
    
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

}
