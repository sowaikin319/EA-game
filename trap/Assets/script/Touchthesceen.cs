using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Touchthesceen : MonoBehaviour
{
    public GameObject device,deviceOpen,stone;

    public int i = 0;
   public void Update()
    {
         if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if(touch.phase == TouchPhase.Began){
              i++;
            }
    }
    if(i == 50){
        device.SetActive(false);
        ObjectMove1.instance.on = 0;
        stone.SetActive(true);
    }

}

}
