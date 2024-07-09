using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//public으로 하면 배열에 new를 안써도 된다.
//배열은 for문과 같이 쓰인다.
public class Arrangement : MonoBehaviour
{
    public int[] students = new int[5]; //배열을 할당을 꼭 해줘야함

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
            Debug.Log("0번 학생의 점수 :" + students[1]);
        }

        /* Debug.Log("0번 학생의 점수 :" + students[0]);
         Debug.Log("0번 학생의 점수 :" + students[1]);
         Debug.Log("0번 학생의 점수 :" + students[2]);
         Debug.Log("0번 학생의 점수 :" + students[3]);
         Debug.Log("0번 학생의 점수 :" + students[4]);*/

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
