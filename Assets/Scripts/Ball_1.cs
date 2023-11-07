using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_1 : MonoBehaviour
{
    Rigidbody rigid;
    
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Wall_E")
            rigid.AddForce(new Vector3(-5, 0, 0), ForceMode.Impulse);
        if (collision.gameObject.name == "Wall_W")
            rigid.AddForce(new Vector3(5, 0, 0), ForceMode.Impulse);

        if (collision.gameObject.name == "Wall_N")
            rigid.AddForce(new Vector3(0, 0, -5), ForceMode.Impulse);
        if (collision.gameObject.name == "Wall_S")
            rigid.AddForce(new Vector3(0, 0, 5), ForceMode.Impulse);
    }
}
