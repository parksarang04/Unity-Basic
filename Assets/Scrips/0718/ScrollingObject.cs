using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//���� ������Ʈ�� �Լ� �������� �����̴� ��ũ��Ʈ
public class ScrollingObject : MonoBehaviour
{
    public float speed = 10f;

   
    void Update()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);//�ʴ� speed �ӵ��� �������� �̵�
    }
}