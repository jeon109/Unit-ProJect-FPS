﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed = 5.0f;
    CharacterController cc;

    private void Start()
    {
        cc = GetComponent<CharacterController>();
    }
    void Update()
    {
        Move();
    }

    private void Move()
    {
        //플레이어 이동

        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 dir = new Vector3(h, 0, v).normalized;
        //dir.Normalize();

        //transform.Translate(dir * speed * Time.deltaTime);

        dir = Camera.main.transform.TransformDirection(dir);
        dir.y = 0;
        cc.Move(dir * speed * Time.deltaTime);
    }
}
