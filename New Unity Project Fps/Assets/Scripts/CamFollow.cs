using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollow : MonoBehaviour
{

    public Transform target; //카메라가 따라다닐 타겟
    public float speed = 10.0f;

    public Transform target1st; 
    bool isFps = false;

    private void LateUpdate()
    {
        FollowTarget();

        ChangeView();
    }

    private void ChangeView()
    {
        if (Input.GetKeyDown("1"))
        {
            isFps = !isFps;
        }
    }

    private void FollowTarget()
    {
        //타겟의 방향 구하기

        Vector3 dir =  target.position - transform.position ;
        dir.Normalize();
        transform.Translate(dir * speed * Time.deltaTime); //타겟에 도착하면 덜덜덜거림. 해결 : 거리를 구해서 고정시킨다.

        //벡터 안의 distansce()함수 사용 정확을 위해 사용, 벡터안의 magnitude 속성 사용 정확을 위해 사용, 벡터안의 sqrMagnitude 속성 사용 속도 빠름

        //1. distansce;
        //if(Vector3.Distance(target.position,transform.position) < 1.0f)
        //{
        //    transform.position = target.position;
        //}
        //
        //2.magnitude
        //
        //float distansce = (target.position - transform.position).magnitude;
        //
        //if(distansce < 1.0f)
        //{
        //    transform.position = target.position;
        //}

        //3.sqrMagnitude(정확한 값은 아니고 크기 비교만 할때 사용
        //성능 빠름



            float distansce = (target.position - transform.position).sqrMagnitude;

            if (distansce < 1.0f)
            {
                transform.position = target.position;
            }





    }
}
