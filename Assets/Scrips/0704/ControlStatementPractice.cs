using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//��� ����
public class ControlStatementPractice : MonoBehaviour
{
    public int love = 100;
    // Start is called before the first frame update
    void Start()
    {
        if (love > 90)
        {
            //love�� 90���� ū ���
            Debug.Log("Ʈ�� ����");
        }
        else if (love > 70)                   //love�� 90���� �۰ų� ����, 70���� ū ���
        {
            Debug.Log("�¿���");
        }
         //if(love <= 70)                 //if�� love �� 70 ���� �� ���
         else
        {
            //if�� love�� 70�ʰ� �̿��� ���
            Debug.Log("��忣��");
        }
    } 
   
}
