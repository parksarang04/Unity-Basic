using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour
{
    public int Hp = 10;          //체력 선언
    public float Distance =0 ;   //이동거리

    public int NeedHp = 3;       //필요체력
    public float MoveDistance = 3.5f; //이동 가능 거리

    // Start is called before the first frame update
    /*void Start()
     {
         MoceObject(3, 3.5f);                //오브젝트 움직임 인수값
         MoceObject(3, 3.5f);                //오브젝트 움직임 인수값
         MoceObject(3, 3.5f);                //오브젝트 움직임 인수값
    } */

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) // 키 입력은 보통 Update에서 진행 하고 if문을 통해서 키가 입력이 되었을 때
        {
            if(NeedHp > Hp)
            {
                Debug.Log(",더 이상 이동 할 수 없습니다. "); //체력이 없으므로 이동 할 수 없다.
            }
            else
            {
                MoceObject(NeedHp, MoveDistance);   //함수를 통해 이동시킨다.
            }
        }
        this.gameObject.transform.position = new Vector3(0, Distance, 0);       //이 오브젝트를 이동 시킨다.
    }

    void MoceObject(int _Hp, float _MoveObject) //MoceObject 함수 선언
    {
        Hp = Hp - _Hp;                              //함수 동작할때 인수로 받아온 Hp를 뺀다.
        Distance = Distance + _MoveObject;          //함수 동작할때 인수로 받아온 거리를 뺀다.

        Debug.Log("남은체력 :" + Hp);
        Debug.Log("이동 거리 : " + Distance);
    }
}
