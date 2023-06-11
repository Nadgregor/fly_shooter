using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class shot_eneme : MonoBehaviour
{
    public Rigidbody enbullet;
    public GameObject eneme;

    void Start()
    {
        Debug.Log("sus");
        InvokeRepeating("enbul", UnityEngine.Random.Range(1f, 2f), UnityEngine.Random.Range(1f,3f)); 
    }
    void enbul()
    {

        Rigidbody bulletClone = (Rigidbody)Instantiate(enbullet, new Vector3(eneme.transform.position.x, eneme.transform.position.y - 1, 0), eneme.transform.rotation);
        bulletClone.velocity = new Vector3(UnityEngine.Random.Range(-1f, 1f), -4, 0);
    }
}
