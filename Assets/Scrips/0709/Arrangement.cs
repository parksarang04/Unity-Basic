using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//public���� �ϸ� �迭�� new�� �Ƚᵵ �ȴ�.
//�迭�� for���� ���� ���δ�.
public class Arrangement : MonoBehaviour
{
    public int[] students = new int[5]; //�迭�� �Ҵ��� �� �������

    void Start()
    {
        
        students[0] = 100;
        students[1] = 90;
        students[2] = 80;
        students[3] = 70;
        students[4] = 60;
        students[5] = 50;

        for (int i =0; i< students.Length; i++)
        {
            Debug.Log("0�� �л��� ���� :" + students[1]);
        }

        /* Debug.Log("0�� �л��� ���� :" + students[0]);
         Debug.Log("0�� �л��� ���� :" + students[1]);
         Debug.Log("0�� �л��� ���� :" + students[2]);
         Debug.Log("0�� �л��� ���� :" + students[3]);
         Debug.Log("0�� �л��� ���� :" + students[4]);*/

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
