using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//���� �鸮�� �� �ڿ� �Ҹ�ó�� ���´�.
[RequireComponent(typeof(AudioSource))] //����� �ҽ� ������Ʈ�� �ݵ�� �ʿ��ϴ�.
public class AudioDistortionEffect : MonoBehaviour
{
    AudioSource audioSource;

    public float distortionLevel = 0.5f;            //����� ����(0.0���� 1.0) ����


    void Start()
    {
        audioSource = GetComponent<AudioSource>();

        AudioDistortionFilter distortionFilter = gameObject.AddComponent<AudioDistortionFilter>();
        distortionFilter.distortionLevel = distortionLevel;
    }
}
