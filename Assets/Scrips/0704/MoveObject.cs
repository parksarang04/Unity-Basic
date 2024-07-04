using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour
{
    public int Hp = 10;          //ü�� ����
    public float Distance =0 ;   //�̵��Ÿ�

    public int NeedHp = 3;       //�ʿ�ü��
    public float MoveDistance = 3.5f; //�̵� ���� �Ÿ�

    // Start is called before the first frame update
    /*void Start()
     {
         MoceObject(3, 3.5f);                //������Ʈ ������ �μ���
         MoceObject(3, 3.5f);                //������Ʈ ������ �μ���
         MoceObject(3, 3.5f);                //������Ʈ ������ �μ���
    } */

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) // Ű �Է��� ���� Update���� ���� �ϰ� if���� ���ؼ� Ű�� �Է��� �Ǿ��� ��
        {
            if(NeedHp > Hp)
            {
                Debug.Log(",�� �̻� �̵� �� �� �����ϴ�. "); //ü���� �����Ƿ� �̵� �� �� ����.
            }
            else
            {
                MoceObject(NeedHp, MoveDistance);   //�Լ��� ���� �̵���Ų��.
            }
        }
        this.gameObject.transform.position = new Vector3(0, Distance, 0);       //�� ������Ʈ�� �̵� ��Ų��.
    }

    void MoceObject(int _Hp, float _MoveObject) //MoceObject �Լ� ����
    {
        Hp = Hp - _Hp;                              //�Լ� �����Ҷ� �μ��� �޾ƿ� Hp�� ����.
        Distance = Distance + _MoveObject;          //�Լ� �����Ҷ� �μ��� �޾ƿ� �Ÿ��� ����.

        Debug.Log("����ü�� :" + Hp);
        Debug.Log("�̵� �Ÿ� : " + Distance);
    }
}
