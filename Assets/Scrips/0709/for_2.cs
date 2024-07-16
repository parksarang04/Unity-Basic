using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class For_2 : MonoBehaviour
{
    //public int sum; //변수 합산 값 지정
    // Start is called before the first frame update
    void Start()
    {
        // for (int i = 1; i < 10; i++) //9단
        //{
        //   for (int j = 1; j < 10; j++) //9단 총 81회 진행
        //   {
        //      int temp = i * j;
        //      Debug.Log(i + "x" + j + "=" + temp);
        //  }

        //}
        int i = 0;
        while(i<10)
        {
            Debug.Log(i + "번째 루프 입니다.");
            i++;
        }


    }
}

