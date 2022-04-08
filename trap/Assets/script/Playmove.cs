using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playmove : MonoBehaviour
{
    public float moveH = 0f;
    public float moveSpeed = 5f;
    public float jumpForce = 5f;
    
    private bool isGrounded;
    public Transform feetPos;
    public float checkRadius;
    public LayerMask whatIsGround;
    private float jumpTimeCounter =1;
    Vector3 movement;
    Rigidbody2D rb;
    public int move1 = 0;

    public bool working  = false;
    public static Playmove instance;

    public void Awake(){
        instance = this;
    }



       public void Start(){
        rb = GetComponent<Rigidbody2D>();
    }
   public void Update(){

               

        if(move1 ==0){
        moveH = SimpleInput.GetAxis("Horizontal");

        rb.velocity = new Vector2(moveH *moveSpeed,rb.velocity.y);

        isGrounded = Physics2D.OverlapCircle(feetPos.position,checkRadius,whatIsGround);
        }
    }
    public void Jump(){
        if(move1 ==0){
        if(jumpTimeCounter >0){
            if(isGrounded == true){
        rb.velocity =Vector2.up * jumpForce;
        jumpTimeCounter -= Time.deltaTime;
            }
        }
        }
  

    }
        public void Change(){
             Debug.Log("WORK");
            Playmove1.instance1.move1 = 0;
          move1 = 1;

    }
}
