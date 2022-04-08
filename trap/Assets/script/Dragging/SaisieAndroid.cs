using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class SaisieAndroid : MonoBehaviour
{
    public GameObject number,minigame2;

    public void trueanswer(){
        number.SetActive(false);
        minigame2.SetActive(false);
     
    }
    public void falseanswer(){
        SceneManager.LoadScene(1);
    }
    public void TRUE2(){
           objectmove.instance1.on = 0;
    }
}
