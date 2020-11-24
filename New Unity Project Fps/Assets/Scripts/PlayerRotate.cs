using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotate : MonoBehaviour
{
    //플레이어 좌우 회전처리 
    public float speed = 150;
    private float angleX;

    private void Start()
    {
        
    }
    private void Update()
    {
        //플레이어 회전
        Rotate();
    }

    private void Rotate()
    {
        float h = Input.GetAxis("Mouse X");
        angleX += h * speed * Time.deltaTime;

        transform.eulerAngles = new Vector3(0, angleX, 0);
    }
}
