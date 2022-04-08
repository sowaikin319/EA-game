using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Minigome : MonoBehaviour
{
    public GameObject SteeringWheel;

    public void OnTriggerStay2D(Collider2D other){
        if(other.tag == "Player"){
            SteeringWheel.SetActive(true);
        }
                if(other.tag == "Player1"){
            SteeringWheel.SetActive(true);
        }
    }
}
