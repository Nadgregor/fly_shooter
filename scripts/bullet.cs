using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class bullet : MonoBehaviour
{
    public Rigidbody bullett;
    public GameObject plane;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            move();
        }

    }
    void move()
    {
        
        Rigidbody bulletClone = (Rigidbody)Instantiate(bullett, new Vector3(plane.transform.position.x , plane.transform.position.y + 1,0 ) , plane.transform.rotation);
        bulletClone.velocity = new Vector3(UnityEngine.Random.Range(-1f, 1f), 10 , 0);
    }
  


}
