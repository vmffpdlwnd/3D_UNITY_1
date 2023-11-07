using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Myball_6 : MonoBehaviour
{
    Rigidbody rigid;

    MeshRenderer mesh;
    Material mat;

    void Start()
    {
        rigid = GetComponent<Rigidbody>();
        //rigid.velocity = Vector3.right;
        //rigid.velocity = new Vector3(2, 3, 4);
        //rigid.AddForce(Vector3.up * 5, ForceMode.Impulse); // 점프동작;

        mesh = GetComponent<MeshRenderer>();
        mat = mesh.material;
    }
    void Update()
    {
        
        if(Input.GetButton("Jump") && transform.position.y < 0)
        {
            rigid.AddForce(Vector3.up * 1, ForceMode.Impulse); // 점프동작
            //Debug.Log(rigid.velocity);
        }
        Debug.Log(transform.position.y);
    }
    private void FixedUpdate()
    {
        Vector3 vec = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")); // -1 ~ +1 사이의 실수값이 발생
        rigid.AddForce (vec, ForceMode.Impulse);

       // rigid.AddTorque(Vector3.back);
    }

    private void OnCollisionEnter(Collision collision)
    {
         if (collision.gameObject.name == "Wall_E")
            rigid.AddForce(new Vector3(-5, 0, 0), ForceMode.Impulse);
         if(collision.gameObject.name =="Wall_W")
            rigid.AddForce(new Vector3(5,0,0), ForceMode.Impulse);

         if(collision.gameObject.name == "Wall_N")
            rigid.AddForce(new Vector3(0,0,-5), ForceMode.Impulse);
         if(collision.gameObject.name == "Wall_S")
            rigid.AddForce(new Vector3(0,0,5), ForceMode.Impulse);

        if (collision.gameObject.name == "Ball_1")
        {
            mat.color = Color.white;
            rigid.velocity = new Vector3(5, 0, 0);
        }

        if (collision.gameObject.name == "Ball_2")
        {
            mat.color = Color.black;
            rigid.velocity = new Vector3(0, 5, 0);
        }

        if (collision.gameObject.name == "Ball_3")
        {
            mat.color = Color.green;
            rigid.velocity = new Vector3(0, 0, 5);
        }

        if (collision.gameObject.name == "Ball_4")
        {
            mat.color = Color.yellow;
            rigid.AddForce(new Vector3(5, 5, 0), ForceMode.Impulse);
        }
        if (collision.gameObject.name == "Ball_5")
        {
            mat.color = Color.red;
            rigid.AddForce(new Vector3(5, 0, 5), ForceMode.Impulse);
        }
        if (collision.gameObject.name == "Ball_6")
        {
            mat.color = Color.blue;
            rigid.AddForce(new Vector3(0, 5, 5), ForceMode.Impulse);
        }
    }

    public void jump()
    {
        rigid.AddForce(Vector3.up * 5, ForceMode.Impulse);
    }
}
