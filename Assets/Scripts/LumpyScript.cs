using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LumpyScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float JumpStrength;
    public LogicManager logic;
    public bool lumpyIsAlive = true;
    Collider2D myCollider2D;


    void Start()
    {
      logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicManager>();
      myCollider2D = gameObject.GetComponent<Collider2D>();
    
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)==true && lumpyIsAlive==true)
        {
            myRigidbody.velocity = Vector2.up * JumpStrength;
        }
        if(transform.position.y > 9 || transform.position.y < -4)
        {
            
            logic.gameOver();
            lumpyIsAlive = false;
            myCollider2D.enabled = false;



        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        lumpyIsAlive = false;
        myCollider2D.enabled = false;


    }

}
