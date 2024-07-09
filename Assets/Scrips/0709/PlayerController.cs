using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody playerRigidboody;      //�̵��� ����� ������ٵ� ������Ʈ
    public float speed = 8f;                // �̵� �ӷ�

    void Start()
    {
        playerRigidboody = GetComponent<Rigidbody>();   //������ٵ� ������Ʈ�� ã�Ƽ� playerRigidboody ������ �Ҵ�(GetComponent���ϰ� ŭ)
    }


    void Update()
    {
         if (Input.GetKey(KeyCode.UpArrow))       //���� ����Ű �Է��� ������ ��� z���� �� �ֱ�
         {
             playerRigidboody.AddForce(0f, 0f, -speed);
         }
         if (Input.GetKey(KeyCode.DownArrow))       //���� ����Ű �Է��� ������ ��� -z���� �� �ֱ�
         {
             playerRigidboody.AddForce(0f, 0f, speed);
         }
         if (Input.GetKey(KeyCode.RightArrow))       //���� ����Ű �Է��� ������ ��� x���� �� �ֱ�
         {
             playerRigidboody.AddForce(-speed ,0f, 0f);
         }
         if (Input.GetKey(KeyCode.LeftArrow))       //���� ����Ű �Է��� ������ ��� -x���� �� �ֱ�
         {
             playerRigidboody.AddForce(speed, 0f, 0f);
         }
        float xInput = Input.GetAxis("Horizontal");
        float zInput = Input.GetAxis("Vertical");

        //���� �̵� �ӵ��� �Է°��� �̵� �ӷ��� ����ؼ� ����

        float xSpeed = xInput * speed;
        float zSpeed = zInput * speed;

        //Vector3 �ӵ��� (xSpeed , 0 , zSpeed)
        Vector3 newVelocity = new Vector3(xSpeed, 0, zSpeed);

        //Rigidboody�ӵ��� newVelociyt �Ҵ�
        playerRigidboody.velocity = newVelocity;

        
    }
    public void Die()
    {
        //�ڽ��� ���� ������Ʈ�� ��Ȱ��ȭ
        gameObject.SetActive(false);           //�ڽ��� ���ӿ�����Ʈ�� �����Ͽ� ��Ȱ��ȭ
    }
}
