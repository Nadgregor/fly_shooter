using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    void Update()
    {
        if (gameObject.transform.position.x > -8)
        {
            if (Input.GetKey(KeyCode.A))
            {
                transform.Translate(Vector3.left * 10 * Time.deltaTime);
            }
        }
        if (gameObject.transform.position.x < 8) { 
            if (Input.GetKey(KeyCode.D))
            {
                transform.Translate(Vector3.right * 10 * Time.deltaTime);
            }
        }
        if (gameObject.transform.position.y < 4f)
        {
            if (Input.GetKey(KeyCode.W))
            {
                transform.Translate(Vector3.up * 5 * Time.deltaTime);
            }
        }
        if (gameObject.transform.position.y > -4f)
        {
            if (Input.GetKey(KeyCode.S))
            {
                transform.Translate(Vector3.down * 13 * Time.deltaTime);
            }
        }

    }
}
