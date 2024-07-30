using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
    public float cycleLenght = 240f;
    public Light directionalLight;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float cycleCompletionPercentage=(Time.time%cycleLenght)/cycleLenght; //���� %
        float sunAngle = cycleCompletionPercentage * 360f;                   //�޾ƿ� %�� 360 ���� ���Ѵ�
        directionalLight.transform.rotation = Quaternion.Euler(sunAngle, 170f, 0);
    }
}
