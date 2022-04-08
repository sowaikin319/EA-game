using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenTouch : MonoBehaviour
{
    public GameObject deviceOpen;
public void OnTriggerEnter2D(Collider2D other){
    if(other.tag =="Player"){
deviceOpen.SetActive(true);
    }
        if(other.tag =="Player1"){
deviceOpen.SetActive(true);
    }
}
public void OnTriggerExit2D(Collider2D other){
    if(other.tag =="Player"){
deviceOpen.SetActive(false);
    }
        if(other.tag =="Player1"){
deviceOpen.SetActive(true);
    }
}
}
