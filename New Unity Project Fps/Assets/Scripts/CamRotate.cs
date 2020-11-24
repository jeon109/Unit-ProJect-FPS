using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamRotate : MonoBehaviour
{
    public float speed = 150;

    float angleX, angleY; //직접 제어

    void Update()
    {
        //카메라 회전
        Rotate();
    }

    private void Rotate()
    {
        float h = Input.GetAxis("Mouse X");
        float v = Input.GetAxis("Mouse Y");

        //Vector3 dir = new Vector3(-v , h , 0);

        //회전은 각각의 축을 기반으로 회전이된다.
        //transform.Rotate(dir * speed * Time.deltaTime); 아래 것과 동일
        //p = p0 + vt;
        // p += vt;
        //transform.eulerAngles += dir * speed * Time.deltaTime;

        //Vector3 angle = transform.eulerAngles;
        //angle += dir * speed * Time.deltaTime;
        //if(angle.x > 60)angle.x = 60;
        //if(angle.x < -60)angle.x = -60;
        //transform.eulerAngles = angle;

        //유니티엔진 내부적으로 -각도는 360도를 더해서 처리한다.

        angleX += h * speed * Time.deltaTime;
        angleY += v * speed * Time.deltaTime;
        angleY = Mathf.Clamp(angleY, -60, 60);

        transform.eulerAngles = new Vector3(-angleY, angleX, 0);

    }
}
