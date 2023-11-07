using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Myball : MonoBehaviour
{
    Rigidbody rigid;

    MeshRenderer mesh;
    Material mat;

    int Ccount;
    int Jcount;
    int Tcount;

    // Start is called before the first frame update
    void Start()
    {
        Jcount = 0;
        Ccount = 0;
        Tcount = 0;

        rigid = GetComponent<Rigidbody>();
        mesh = GetComponent<MeshRenderer>();
        mat = mesh.material;

        mat.color = Color.red;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetButton("Jump"))
        {
            if(Jcount>=3) 
            {
                Jcount = 0;
                rigid.AddForce(Vector3.up * 4, ForceMode.Impulse); // 점프동작
            }
            Jcount = Jcount+1;
        }

        if (Input.GetButton("Turbo"))
        {
            rigid.mass = 1.0f;
            Tcount= Tcount+1;
            if(Tcount > 0)
            {
                rigid.mass = 0f;
            }
        }
       
    }
    private void FixedUpdate()
    {
        Vector3 vec = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")); // -1 ~ +1 사이의 실수값이 발생
        rigid.AddForce(vec, ForceMode.Impulse);
    }

    private void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.name == "OtherballA")
        {
            Ccount=Ccount+1;
            Debug.Log(Ccount + "번 충돌되었습니다.");
            mat.color = Color.yellow;

        }
        if (collision.gameObject.name == "OtherballB")
        {
            Ccount = Ccount + 1;
            Debug.Log(Ccount + "번 충돌되었습니다.");
            mat.color = Color.yellow;

        }
        if (collision.gameObject.name == "OtherballC")
        {
            Ccount = Ccount + 1;
            Debug.Log(Ccount + "번 충돌되었습니다.");
            mat.color = Color.yellow;

        }
        if(collision.gameObject.name == "Tower")
        {
            rigid.AddForce(new Vector3(0, 10, 0), ForceMode.Impulse);
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.name == "OtherballA")
        {
            mat.color = Color.red;

        }
        if (collision.gameObject.name == "OtherballB")
        {
            mat.color = Color.red;

        }
        if (collision.gameObject.name == "OtherballC")
        {
            mat.color = Color.red;

        }
    }

    
}
