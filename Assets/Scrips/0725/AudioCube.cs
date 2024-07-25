using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioCube : MonoBehaviour
{
    public GameObject sampleCubePrefab;
    GameObject[] sampleCube = new GameObject[512];         //���� ť�� �迭
    public float maxScale = 1000;                           //ť���� �ִ� ũ��

    void Start()
    {
        for (int i = 0; i < sampleCube.Length; i++)
        {
            GameObject temp = Instantiate(sampleCubePrefab);        //ť�� ������ ��
            temp.transform.position = this.transform.position;      //ť�� �ʱ� ��ġ 
            temp.transform.parent = this.transform;                 //ť�� �θ� ����
            temp.name = "Cube" + i.ToString("000");                 //ť�� �̸� ����
            this.transform.eulerAngles = new Vector3(0, -0.73125f * i, 0);      // 360 / 512 �� 
            temp.transform.position = Vector3.forward * 100;
            sampleCube[i] = temp;
        }
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < sampleCube.Length; i++)
        {
            if (sampleCube[i] != null)
            {
                sampleCube[i].transform.localScale
                    = new Vector3(10, (AudioPeer.samples[i] * maxScale) + 2, 10) * 0.1f;
            }
        }
    }
}
