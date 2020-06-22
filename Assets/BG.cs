using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BG : MonoBehaviour
{
    public float BGspeed;
    float BGPositionX;
    float BG1PositionX;

    void Start()
    {
        BGPositionX = transform.position.x;
        BG1PositionX = GameObject.Find ("BG1").transform.position.x;
    }

   
    void Update()
    {
        transform.position = new Vector3 (transform.position.x + BGspeed, transform.position.y, transform.position.z);
        //if(transform.position.x < (BG1PositionX * -1f))
        //{
        //    transform.position = new Vector3 (BG1PositionX, transform.position.y, transform.position.z);  
		//}
    }
}
