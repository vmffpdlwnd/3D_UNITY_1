using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class player_3 : MonoBehaviour
{
    public TextMeshProUGUI Score;
    //int count = 0;

    public TMP_InputField input_Mass;

    public TextMeshProUGUI text;

    float mass;

    Rigidbody rigid;
    private void Start()
    {
        rigid = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        //Score.text = count.ToString();
        //++count;
        if(Input.GetButton("Jump"))
        {
            rigid.AddForce(new Vector3(0,5,0),ForceMode.Impulse);
        }

    }
    public void Calc_1()
    {
        if (float.TryParse(input_Mass.text, out mass))
            rigid.mass = mass + 5.0f;
        else
            rigid.mass = 1.0f;

        Score.text = rigid.mass.ToString();
        text.text = "최종 질량 " + "x" + " 5" + " =";
    }

    public void jump()
    {
        rigid.AddForce(Vector3.up * 5, ForceMode.Impulse);
    }
}

