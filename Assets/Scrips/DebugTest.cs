using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugTest : MonoBehaviour//MonoBehaviour로 색이 나와야 연결됐음을 알 수 있다.
{
    //처음 1번만 함수 호출이 된다.
    void Start()
    {
        //Debug.Log("첫 함수 호출");
        Debug.LogWarning("오브젝트 이름 확인 : " + gameObject.name);
    }

    // 매 프라임마다 함수가 호출이 된다.
    void Update()
    {
      
    }
}
