using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class RestartGAme : MonoBehaviour
{

    public void OnTriggerEnter2D(Collider2D other){
        if(other.tag == "Player"){
        SceneManager.LoadScene(1);
    }
      if(other.tag == "Player1"){
        SceneManager.LoadScene(1);
    }
    }
}
