using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_1 : MonoBehaviour
{
    Rigidbody rigid;
    public float jumpPower;

    void Start()
    {
        rigid = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        if ((Input.GetKeyDown("space")))
        {
            Vector3 vec = new Vector3(0, jumpPower, 0);
            rigid.AddForce(vec, ForceMode.Impulse);
        }
    }
    private void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        Vector3 vec = new Vector3(h, 0, v);
        rigid.AddForce(vec, ForceMode.Impulse);
    }
}
