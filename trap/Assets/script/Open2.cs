using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Open2 : MonoBehaviour
{
    public GameObject Enter,number,openmingame;

    public int i = 0;

    // Update is called once per frame
    public void OnTriggerEnter2D(Collider2D other){
        if(i == 0){
        if(other.tag == "Player"){
            Enter.SetActive(true);
           
        }
                if(other.tag == "Player1"){
            Enter.SetActive(true);
        }
        }
    }
    public void OpenminiGAme(){
        i = 1;
        Enter.SetActive(false);
       number.SetActive(true);
        openmingame.SetActive(true);
    }
}
