using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))] //����� �ҽ� ������Ʈ�� �ݵ�� �ʿ��ϴ�.
public class AudioHighPassEffect : MonoBehaviour
{
    AudioSource audioSource;                            //AudioSource ������Ʈ�� ������ ����

    //�� ���� ���ļ� (Hz)
    public float cutoffFrequency = 500.0f;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();

        //AudioHighPassFiler ������Ʈ�� �߰� �ϰ� ����
        AudioHighPassFilter highPassFilter = gameObject.AddComponent<AudioHighPassFilter>();
        highPassFilter.cutoffFrequency = cutoffFrequency;
    }
}
