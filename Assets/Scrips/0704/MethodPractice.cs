using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//�޼��� ���� 
public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        float distance = GetDistance(2, 2, 5, 6);
        Debug.Log("(2,2)���� (5,6)������ �Ÿ� " + distance.ToString());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    float GetDistance(float x1, float y1, float x2, float y2) //�Լ� ����
    {
        float width = x2 - x1;                                //�Ÿ� ���� ����.
        float heigh = y2 - y1;

        float distance = width * width + heigh * heigh;       //w,h�� �������� distance ���� ���� �־��ش�.
        distance = Mathf.Sqrt(distance);                      // ��Ʈ���� �־��ش�.

        return distance;                                      //�Լ��� ��ȯ���� ���� ���ش�.
    }
}
