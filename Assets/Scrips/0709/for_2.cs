using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class For_2 : MonoBehaviour
{
    //public int sum; //���� �ջ� �� ����
    // Start is called before the first frame update
    void Start()
    {
        // for (int i = 1; i < 10; i++) //9��
        //{
        //   for (int j = 1; j < 10; j++) //9�� �� 81ȸ ����
        //   {
        //      int temp = i * j;
        //      Debug.Log(i + "x" + j + "=" + temp);
        //  }

        //}
        int i = 0;
        while(i<10)
        {
            Debug.Log(i + "��° ���� �Դϴ�.");
            i++;
        }


    }
}

