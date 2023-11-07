using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Myball_1 : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI Score;
    [SerializeField] 
    TextMeshProUGUI Final_Score;
    [SerializeField]
    TMP_InputField input_Mass;

    int count = 0;

    Rigidbody rigid;

    MeshRenderer mesh;
    Material mat;

    int mass = 1;

    private void Start()
    {
        rigid = GetComponent<Rigidbody>();
        mesh = GetComponent<MeshRenderer>();
        mat = mesh.material;

        mat.color = Color.red;
    }

    private void Update()
    {
        Score.text = count.ToString();

        if (count == 0)
            rigid.mass = 1;
        else if (int.TryParse(input_Mass.text, out mass))
            rigid.mass = count * mass;
        else
            rigid.mass = count * 1;

        Final_Score.text = rigid.mass.ToString();

    }

    private void FixedUpdate()
    {
        Vector3 vec = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")); // -1 ~ +1 사이의 실수값이 발생
        rigid.AddForce(vec, ForceMode.Impulse);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Otherball"))
        {
            ++count;

        }

    }

}

