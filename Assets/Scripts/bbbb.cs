using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bbbb : MonoBehaviour
{
    Rigidbody rigid;

    private void Start()
    {
        rigid = GetComponent<Rigidbody>();
        
    }

    private void Update()
    {
        if (Input.GetButton("Successive_Jump"))
        {
            Vector3 vec = new Vector3(0, 1, 0);
            rigid.AddForce(vec, ForceMode.Impulse);
        }
    }
}
