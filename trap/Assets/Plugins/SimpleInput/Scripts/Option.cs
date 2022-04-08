using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Option : MonoBehaviour
{
    public  GameObject Option1;

    public void Open(){
        Option1.SetActive(true);
    }
    public void Start1(){
        Option1.SetActive(false);
    }
    public void Restart(){
        SceneManager.LoadScene(1);
    }
    public void Exit(){
       SceneManager.LoadScene(0);
    }
}   
