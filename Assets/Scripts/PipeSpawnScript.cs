using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnScript : MonoBehaviour
{
    public GameObject pipe;
    public float spawnRate ;
    //spawnRate is how many seconds it should be between spawns.
    private float timer = 0;
    //timer is the number that counts up

    public float heightOffset ;
    void Start()
    {
        spawnPipe();   
    }

    
    void Update()
    {
        if(timer < spawnRate)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
                spawnPipe();
                timer = 0;
        }

        
    }
    void spawnPipe()
    {
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;
        
        Instantiate(pipe, new Vector3(transform.position.x,Random.Range(lowestPoint,highestPoint),0),transform.rotation);

    }
}
