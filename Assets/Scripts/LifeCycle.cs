using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCycle : MonoBehaviour
{
    private void Update()
    {
        /*
        if (Input.anyKeyDown)
            Debug.Log("플레이어가 임의의 키를 누름");
        if (Input.anyKey)
            Debug.Log("플레이어가 임의의 키를 누른상태임");

        // 키보드 입력
        if (Input.GetKeyDown(KeyCode.Return))
            Debug.Log("아이템을 구매");
        if (Input.GetKey(KeyCode.LeftArrow))
            Debug.Log("왼쪽이동 시작");
        if (Input.GetKeyUp(KeyCode.RightArrow))
            Debug.Log("오른쪽 이동 중지");

        //마우스 입력
        if (Input.GetMouseButtonDown(0))
            Debug.Log("미사일 발사");
        if (Input.GetMouseButton(0))
            Debug.Log("미사일 모으기");
        if (Input.GetMouseButtonUp(0))
            Debug.Log("슈퍼 미사일 발사");
        if (Input.GetButtonDown("Jump"))
            Debug.Log("점프");
        if (Input.GetButton("Jump"))
            Debug.Log("점프 모으기");
        if (Input.GetButtonUp("Jump"))
            Debug.Log("슈퍼 점프");
        */
        /*

        if (Input.GetButtonDown("Fire1"))
            Debug.Log("파이어 발사");
        if (Input.GetButton("Fire1"))
            Debug.Log("파이어 모으기");
        if (Input.GetButtonUp("Fire1"))
            Debug.Log("슈퍼파이어");

        if (Input.GetButtonDown("Fire2"))
            Debug.Log("메가파이어");
        */

        if (Input.GetButton("Horizontal"))
            Debug.Log("좌우 이동..." + Input.GetAxisRaw("Horizontal")*100);
        if (Input.GetButton("Vertical"))
            Debug.Log("상하 이동..." + Input.GetAxis("Vertical") * 100);
    }



}
