using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//메서드 연습 
public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        float distance = GetDistance(2, 2, 5, 6);
        Debug.Log("(2,2)에서 (5,6)까지의 거리 " + distance.ToString());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    float GetDistance(float x1, float y1, float x2, float y2) //함수 생성
    {
        float width = x2 - x1;                                //거리 값을 뺀다.
        float heigh = y2 - y1;

        float distance = width * width + heigh * heigh;       //w,h의 제곱값을 distance 변수 값에 넣어준다.
        distance = Mathf.Sqrt(distance);                      // 루트값을 넣어준다.

        return distance;                                      //함수의 반환값을 선언 해준다.
    }
}
