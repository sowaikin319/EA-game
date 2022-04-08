using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{  
    private Touch touch;

    public GameObject Steering,stone;
    private Vector3 touchPosition;
    
   
    private Quaternion rotationY;

    public float rotZ = 0;

    public int i =0 ;

    public bool trueOn = true;
    private float rotatSpeedModifier = -70f;


    void Update(){
        
        if(Input.touchCount>0){
            touch = Input.GetTouch(0);
            if(touch.phase == TouchPhase.Moved){
                rotZ += Time.deltaTime *rotatSpeedModifier;
                transform.rotation = Quaternion.Euler(0,0,rotZ);
               
                    if(rotZ <-100 && rotZ >-120 ){
                     i = 1;
                }else if(rotZ <-200 && rotZ >-220){
                 i =2;
                }
                else if(rotZ <-300 && rotZ >-390){
                    i = 3;
                }else if(rotZ <-400 && rotZ >-420){
                    i = 4;
                }else if(rotZ <-500 && rotZ >-520){
                    i = 5;
                }else if(rotZ <-600 && rotZ >-620){
                    i = 6;
                }else if(rotZ <-700 && rotZ >-720){
                    i = 7;
                }else if(rotZ <-800 && rotZ >-820){
                    i = 8;
                }else if(rotZ <-900 && rotZ >-920){
                    i = 9;
                }else if(rotZ <-1000 && rotZ >-1020){
                    i = 10;
                }
            }
    }
    if(i == 10){
        Steering.SetActive(false);
        stone.SetActive(false);
    }
    }
}
    



