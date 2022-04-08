using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dragging8 : MonoBehaviour
{
 private float dist;
    private bool dragging = false;

    private Vector3 offset;

    private Transform toDrag;

    private float speedModifier = 0.01f;
    public bool thisgame = false;

    public static Dragging8 instance8;

    public bool click1 = false;
    public void Awake(){
        instance8 =this;
    }
    void Update(){
       

        if(Input.touchCount != 1){
            dragging = false;
            return;
        }
        Touch touch = Input.touches[0];
        Vector3 pos  = touch.position;


         if(thisgame == true)
       {
            if(touch.phase == TouchPhase.Moved){
               transform.position =new Vector2(  transform.position.x + touch.deltaPosition.x * speedModifier,
               transform.position.y+ touch.deltaPosition.y * speedModifier);
              
           }
        }

    }
}
