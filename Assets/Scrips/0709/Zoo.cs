using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zoo : MonoBehaviour
{
    //클래스 연습
    // Start is called before the first frame update
    void Start()
    {//tom이라는 지역변수가 멤버가 되기 위해선 .(점) 이 필요.
        AnimalClass tom = new AnimalClass();    //new 로 클래스를 할당함
        tom.name = "톰";                        //오브젝트 내부의 변수 -> 멤버 -> 멤버에 접근하기위해서는 점(.) 연산자로 접근[접근제어자가 허락할 경우만]
        tom.sound = "월월";

        tom.PlaySound();

        //다른 객체를 할당하여 독립적으로 동작하는 것을 보여주기 위해서
        AnimalClass bob = new AnimalClass();
        bob.name = "밥";
        bob.sound = "냐용";

        bob.PlaySound();
    }
}
