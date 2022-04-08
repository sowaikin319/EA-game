using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pendulum : MonoBehaviour
{
    public Rigidbody2D body2d;
    public float left;
    public float right;
    public float velocityThrehold;

    void Start()
    {
        body2d = GetComponent<Rigidbody2D>();
        body2d.angularVelocity = velocityThrehold;
    }
     void Update()
    {
        Push();
    }
    public void Push()
    {
        if(transform.rotation.z > 0 && transform.rotation.z<right && (body2d.angularVelocity > 0)&&body2d.angularVelocity < velocityThrehold)
        {
            body2d.angularVelocity = velocityThrehold;
        }else if(transform.rotation.z <0 && transform.rotation.z > left && (body2d.angularVelocity < 0) && body2d.angularVelocity > velocityThrehold * -1)
        {
            body2d.angularVelocity = velocityThrehold * -1;
        }
    }

}
