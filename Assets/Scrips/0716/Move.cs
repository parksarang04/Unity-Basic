using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public Transform childTransform;    //������ �ڽ� ���� ������Ʈ�� Ʈ������ ����


    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0, -1, 0);     //�ڽ��� ���� ��ġ�� (0,-1,0)���� 
        childTransform.localPosition = new Vector3(0, 2, 0); //�ڽ��� ���� ��ġ�� (0,-1,0)���� 

        transform.rotation = Quaternion.Euler(new Vector3(0, 0, 30));   //�ڽ��� ���� ȸ����(0,0,30)
        transform.localRotation = Quaternion.Euler(new Vector3(0, 60, 0));//�ڽ���  ���� ȸ����(0,0,30)

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.UpArrow))   //����Ű�� ������� �����̵� 
        {
            transform.Translate(new Vector3(0, 1, 0) * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.DownArrow))    //�Ʒ���Ű�� ������� �����̵� 
        {
            transform.Translate(new Vector3(0, -1, 0) * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftArrow))    //����Ű�� ������� �����̵� 
        {
            transform.Translate(new Vector3(0, 0, 180) * Time.deltaTime); //�ڽ��� �ʴ� (0, 0, 180)ȸ��
            childTransform.Rotate(new Vector3(0, 180, 0) * Time.deltaTime);   //�ڽ��� �ʴ� (0,180,0)ȸ��
        }
        if (Input.GetKey(KeyCode.RightArrow))    //������Ű�� ������� �����̵� 
        {
            transform.Translate(new Vector3(0, 0, -180) * Time.deltaTime);  //�ڽ��� �ʴ� (0, 0, -180)ȸ��
            childTransform.Rotate(new Vector3(0, -180, 0) * Time.deltaTime); //�ڽ��� �ʴ� (0, -180, 0)ȸ��
        }
    }
}
