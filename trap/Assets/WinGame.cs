using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinGame : MonoBehaviour
{   
    public bool Win = true;
    public static WinGame intance;
    public void Awake(){
        intance = this;
    }
    public void OnTriggerEnter2D(Collider2D other){
        if(other.tag == "Player"){
            Win = false;
        }
    }
        public void OnTriggerExit2D(Collider2D other){
        if(other.tag == "Player"){
            Win = true;
        }
    }
}
