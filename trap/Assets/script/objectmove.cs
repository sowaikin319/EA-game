using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectmove : MonoBehaviour
{
public GameObject objectToMove;
    public Transform startPoint, endPoint;
    public float moveSpeed = 3f;
    private Vector3 target;
    public int on = 1;

    public static objectmove instance1;

    public void Awake(){
        instance1= this;
    }
    void Start()
    {
        target = endPoint.position;
    }

       public void Update()
    {
         if(on == 0){
        objectToMove.transform.position = Vector3.MoveTowards(objectToMove.transform.position, target, moveSpeed * Time.deltaTime);
        if (objectToMove.transform.position == endPoint.position)
        {
            target = startPoint.position;
        }
        if (objectToMove.transform.position == startPoint.position)
        {
            target = endPoint.position;
        }
    }
    }
}
