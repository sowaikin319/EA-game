using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stay : MonoBehaviour
{
    public GameObject switch1;

    public void OnTriggerEnter2D(Collider2D other){
        if(other.tag == "Player"){
            switch1.SetActive(true);
        }
            if(other.tag =="Player1"){
            switch1.SetActive(true);
    }
    }
    public void OnTriggerExit2D(Collider2D other){
        if(other.tag == "Player"){
            switch1.SetActive(false);
        }
              if(other.tag == "Player1"){
            switch1.SetActive(false);
        }
    }
}
