using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugTest : MonoBehaviour//MonoBehaviour�� ���� ���;� ��������� �� �� �ִ�.
{
    //ó�� 1���� �Լ� ȣ���� �ȴ�.
    void Start()
    {
        //Debug.Log("ù �Լ� ȣ��");
        Debug.LogWarning("������Ʈ �̸� Ȯ�� : " + gameObject.name);
    }

    // �� �����Ӹ��� �Լ��� ȣ���� �ȴ�.
    void Update()
    {
      
    }
}
