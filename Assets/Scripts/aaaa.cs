using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aaaa : MonoBehaviour
{
    Vector3 target = new Vector3(11, 1.7f, 0);
    Vector3 velo = Vector3.zero;
    

    void Start()
    {
        //Vector3 vec = new Vector3(3, 0, 0);
        //transform.Translate(vec);
    }

    void Update()
    {
        //Vector3 vec = new Vector3(0, 0.1f, 0);
        //transform.Translate(vec); 

        //Vector3 vec = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxisRaw("Vertical"), 0);
        //transform.Translate(vec);

        //transform.position = Vector3.MoveTowards(transform.position, target, 2f);
        //transform.position = Vector3.SmoothDamp(transform.position, target, ref velo, 0.5f);
        //transform.position = Vector3.Lerp(transform.position, target, 0.5f);
        transform.position = Vector3.Slerp(transform.position, target, 0.05f);
    }
}
