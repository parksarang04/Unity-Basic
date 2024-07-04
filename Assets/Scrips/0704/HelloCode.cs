using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//class안에서 생성하면 모든 역에서 사용가능
public class HelloCode : MonoBehaviour
{
    //class안에서 생성하고 유니티 가면 리스트로 정리된것을 볼 수 있다.
    public string characterName = "라라"; //문자열 변수 선언 (string)
    public char bloodType = 'A';          //문자 변수 선언 (char)
    public int age = 17;                  //정수 변수 선언 (int)
    public float heigh = 168.3f;          //실수 변수 선언 (float)
    public bool isFenale = true;          //참 거짓을 판별하는 변수 선언 (bool)

    //string characterName = "라라"-> 다른 함수에서도 사용하고 싶으면 class안에서 변수 작성.
    // Start is called before the first frame update
    void Start()
    {
        //start 안에 생성된 변수 = 지역변수.start 를 벗어나면 스코프를 벗어났기에 사용할 수 없다.
        

        //생성하는 변\수를 콘솔에 출력
        Debug.Log("캐릭터 이름 : " + characterName);     //캐릭터 이름 : 라라
        Debug.Log("캐릭터 혈액형 : " + bloodType);       //캐릭터 성별 : A
        Debug.Log("캐릭터 나이 : " + age.ToString());    // Debug.Log("캐릭터 나이 : " + age) 와 같은 동작을 하지만 형 변환을 해주는것이 좋다.
        Debug.Log("캐릭터 키: " + heigh.ToString());     // Debug.Log("캐릭터 키: " + heigh) 와 같은 동작을 하지만 형 변환을 해주는것이 좋다.
        Debug.Log("여성인가? : " + isFenale);            //Debug.Log("여성인가? : " + isFenale) 와 같은 동작을 하지만 형 변환을 해주는것이 좋다.

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
