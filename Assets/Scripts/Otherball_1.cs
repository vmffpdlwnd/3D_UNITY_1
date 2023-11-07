using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Otherball_1 : MonoBehaviour
{
    Rigidbody rigid;

    MeshRenderer mesh;
    Material mat;

    int count = 0;

    private void Start()
    {
        rigid = GetComponent<Rigidbody>();
        mesh = GetComponent<MeshRenderer>();
        mat = mesh.material;

        mat.color = Color.blue;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            mat.color = Color.yellow;
            count++;
            if (count >= 2)
            {
                Destroy(gameObject);
            }
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            mat.color = Color.blue;

        }
    }
}

