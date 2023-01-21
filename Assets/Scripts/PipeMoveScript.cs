using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMoveScript : MonoBehaviour
{
    public float moveSpeed = 5;
    public float deadZone = -10;
    void Start()
    {
        
    }

   
    void Update()
    {
        transform.position = transform.position + (Vector3.left * moveSpeed)*Time.deltaTime;
        //*Time.deltaTime ile frameratesi düþüyor yoksa aþýrý fps kullanýyoruz 

        if (transform.position.x < deadZone)
        {
            Destroy(gameObject);
            
            //(if the pipe exceeds -10 it will be destroyed)
        }

    }
}
