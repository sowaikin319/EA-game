using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class WinGame2 : MonoBehaviour
{
    public bool Win = true;

    public GameObject WinGame1;

    public void Update(){
        if(Win ==  false && WinGame.intance.Win ==false){
           WinGame1.SetActive(true);
           Time.timeScale = 1;
        }
    }
    public void OnTriggerEnter2D(Collider2D other){
        if(other.tag == "Player1"){
            Win = false;
        }
    }
        public void OnTriggerExit2D(Collider2D other){
        if(other.tag == "Player1"){
            Win = true;
        }
    }

    public void REstart(){
        SceneManager.LoadScene(1);
    }
    public void Exit(){
        SceneManager.LoadScene(0);
    }
}
