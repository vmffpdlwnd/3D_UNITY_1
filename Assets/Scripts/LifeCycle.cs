using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCycle : MonoBehaviour
{
    private void Update()
    {
        /*
        if (Input.anyKeyDown)
            Debug.Log("�÷��̾ ������ Ű�� ����");
        if (Input.anyKey)
            Debug.Log("�÷��̾ ������ Ű�� ����������");

        // Ű���� �Է�
        if (Input.GetKeyDown(KeyCode.Return))
            Debug.Log("�������� ����");
        if (Input.GetKey(KeyCode.LeftArrow))
            Debug.Log("�����̵� ����");
        if (Input.GetKeyUp(KeyCode.RightArrow))
            Debug.Log("������ �̵� ����");

        //���콺 �Է�
        if (Input.GetMouseButtonDown(0))
            Debug.Log("�̻��� �߻�");
        if (Input.GetMouseButton(0))
            Debug.Log("�̻��� ������");
        if (Input.GetMouseButtonUp(0))
            Debug.Log("���� �̻��� �߻�");
        if (Input.GetButtonDown("Jump"))
            Debug.Log("����");
        if (Input.GetButton("Jump"))
            Debug.Log("���� ������");
        if (Input.GetButtonUp("Jump"))
            Debug.Log("���� ����");
        */
        /*

        if (Input.GetButtonDown("Fire1"))
            Debug.Log("���̾� �߻�");
        if (Input.GetButton("Fire1"))
            Debug.Log("���̾� ������");
        if (Input.GetButtonUp("Fire1"))
            Debug.Log("�������̾�");

        if (Input.GetButtonDown("Fire2"))
            Debug.Log("�ް����̾�");
        */

        if (Input.GetButton("Horizontal"))
            Debug.Log("�¿� �̵�..." + Input.GetAxisRaw("Horizontal")*100);
        if (Input.GetButton("Vertical"))
            Debug.Log("���� �̵�..." + Input.GetAxis("Vertical") * 100);
    }



}
