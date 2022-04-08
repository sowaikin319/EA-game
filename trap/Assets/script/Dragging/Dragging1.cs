using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dragging1 : MonoBehaviour
{
  private float dist;
    private bool dragging = false;

    private Vector3 offset;

    private Transform toDrag;

    private float speedModifier = 0.01f;
    public bool thisgame = false;

       public static Dragging1 instance1;

    public void Awake(){
        instance1 = this;
    }
    void Update(){
       

        if(Input.touchCount != 1){
            dragging = false;
            return;
        }
        Touch touch = Input.touches[0];
        Vector3 pos  = touch.position;


        
        if(touch.phase == TouchPhase.Moved){
           if(thisgame == true){
               transform.position =new Vector2(  transform.position.x + touch.deltaPosition.x * speedModifier,
               transform.position.y+ touch.deltaPosition.y * speedModifier);
              
           }
        }

    }
}
