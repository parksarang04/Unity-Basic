using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//class�ȿ��� �����ϸ� ��� ������ ��밡��
public class HelloCode : MonoBehaviour
{
    //class�ȿ��� �����ϰ� ����Ƽ ���� ����Ʈ�� �����Ȱ��� �� �� �ִ�.
    public string characterName = "���"; //���ڿ� ���� ���� (string)
    public char bloodType = 'A';          //���� ���� ���� (char)
    public int age = 17;                  //���� ���� ���� (int)
    public float heigh = 168.3f;          //�Ǽ� ���� ���� (float)
    public bool isFenale = true;          //�� ������ �Ǻ��ϴ� ���� ���� (bool)

    //string characterName = "���"-> �ٸ� �Լ������� ����ϰ� ������ class�ȿ��� ���� �ۼ�.
    // Start is called before the first frame update
    void Start()
    {
        //start �ȿ� ������ ���� = ��������.start �� ����� �������� ����⿡ ����� �� ����.
        

        //�����ϴ� ��\���� �ֿܼ� ���
        Debug.Log("ĳ���� �̸� : " + characterName);     //ĳ���� �̸� : ���
        Debug.Log("ĳ���� ������ : " + bloodType);       //ĳ���� ���� : A
        Debug.Log("ĳ���� ���� : " + age.ToString());    // Debug.Log("ĳ���� ���� : " + age) �� ���� ������ ������ �� ��ȯ�� ���ִ°��� ����.
        Debug.Log("ĳ���� Ű: " + heigh.ToString());     // Debug.Log("ĳ���� Ű: " + heigh) �� ���� ������ ������ �� ��ȯ�� ���ִ°��� ����.
        Debug.Log("�����ΰ�? : " + isFenale);            //Debug.Log("�����ΰ�? : " + isFenale) �� ���� ������ ������ �� ��ȯ�� ���ִ°��� ����.

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
