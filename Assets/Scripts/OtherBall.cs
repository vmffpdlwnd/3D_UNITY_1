using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OtherBall : MonoBehaviour
{
    Rigidbody rigid;

    MeshRenderer mesh;
    Material mat;

    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
        mesh = GetComponent<MeshRenderer>();
        mat = mesh.material;

        mat.color = Color.blue;
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.name == "Tower")
        {
            rigid.velocity = new Vector3(-2, -1, -2);
        }
    }
}
