using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;   
public class anson : MonoBehaviour
{
    public string answer;
    
    public GameObject minigame;

 
    public void Confirm(){

           minigame.SetActive(false);
           objectMove2.instance.on =0;
            Debug.Log("Work");
       
       
    }

}
