using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zoo : MonoBehaviour
{
    //Ŭ���� ����
    // Start is called before the first frame update
    void Start()
    {//tom�̶�� ���������� ����� �Ǳ� ���ؼ� .(��) �� �ʿ�.
        AnimalClass tom = new AnimalClass();    //new �� Ŭ������ �Ҵ���
        tom.name = "��";                        //������Ʈ ������ ���� -> ��� -> ����� �����ϱ����ؼ��� ��(.) �����ڷ� ����[���������ڰ� ����� ��츸]
        tom.sound = "����";

        tom.PlaySound();

        //�ٸ� ��ü�� �Ҵ��Ͽ� ���������� �����ϴ� ���� �����ֱ� ���ؼ�
        AnimalClass bob = new AnimalClass();
        bob.name = "��";
        bob.sound = "�Ŀ�";

        bob.PlaySound();
    }
}
