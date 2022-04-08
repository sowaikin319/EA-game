using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxControll : MonoBehaviour
{
    public GameObject Block1,Block2,Block3;
public void OnTriggerEnter2D(Collider2D other){
    if(other.tag == "Box"){
        Block1.SetActive(true);
        Block2.SetActive(true);
        Block3.SetActive(true);
    }
}
public void OnTriggerExit2D(Collider2D other){
    if(other.tag == "Box"){
        Block1.SetActive(false);
        Block2.SetActive(false);
        Block3.SetActive(false);
    }
    
}
}
