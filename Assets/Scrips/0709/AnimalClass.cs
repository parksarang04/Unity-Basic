using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//new�����ڴ� Ŭ�����κ��� �ν��Ͻ��� ����
//Ŭ���� ����
public class AnimalClass //���� ������Ʈ�� �ƴ� �Ϲ� Ŭ�����̱� ������ ��� �Ѱ��� ����.
{
    //������ ���� ����
    public string name; //�̸� ���� ����
    public string sound; // �����Ҹ� ���� ����

    //�����Ҹ��� ����ϴ� �޼���
    public void PlaySound()
    {
        Debug.Log(name + ":" + sound);      //�α׷� �̸��� �����Ҹ��� ��� �ϳ�.
    }
}
