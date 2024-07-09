using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody playerRigidboody;      //이동에 사용할 리지드바디 컴포넌트
    public float speed = 8f;                // 이동 속력

    void Start()
    {
        playerRigidboody = GetComponent<Rigidbody>();   //리지드바디 컴포넌트를 찾아서 playerRigidboody 변수에 할당(GetComponent부하가 큼)
    }


    void Update()
    {
         if (Input.GetKey(KeyCode.UpArrow))       //위쪽 방향키 입력이 감지된 경우 z방향 힘 주기
         {
             playerRigidboody.AddForce(0f, 0f, -speed);
         }
         if (Input.GetKey(KeyCode.DownArrow))       //위쪽 방향키 입력이 감지된 경우 -z방향 힘 주기
         {
             playerRigidboody.AddForce(0f, 0f, speed);
         }
         if (Input.GetKey(KeyCode.RightArrow))       //위쪽 방향키 입력이 감지된 경우 x방향 힘 주기
         {
             playerRigidboody.AddForce(-speed ,0f, 0f);
         }
         if (Input.GetKey(KeyCode.LeftArrow))       //위쪽 방향키 입력이 감지된 경우 -x방향 힘 주기
         {
             playerRigidboody.AddForce(speed, 0f, 0f);
         }
        float xInput = Input.GetAxis("Horizontal");
        float zInput = Input.GetAxis("Vertical");

        //실제 이동 속도를 입력값과 이동 속력을 사용해서 결정

        float xSpeed = xInput * speed;
        float zSpeed = zInput * speed;

        //Vector3 속도를 (xSpeed , 0 , zSpeed)
        Vector3 newVelocity = new Vector3(xSpeed, 0, zSpeed);

        //Rigidboody속도에 newVelociyt 할당
        playerRigidboody.velocity = newVelocity;

        
    }
    public void Die()
    {
        //자신의 게임 오브젝트를 비활성화
        gameObject.SetActive(false);           //자신의 게임오브젝트에 접근하여 비활성화
    }
}
