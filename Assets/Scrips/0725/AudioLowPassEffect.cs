using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))] //����� �ҽ� ������Ʈ�� �ݵ�� �ʿ��ϴ�.
public class AudioLowPassEffect : MonoBehaviour
{
    AudioSource audioSource;

    public float cutoffFrequency = 500.0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        audioSource = GetComponent<AudioSource>();

        //AudioHighPassFiler ������Ʈ�� �߰� �ϰ� ����
        AudioLowPassFilter highPassFilter = gameObject.AddComponent<AudioLowPassFilter>();
        highPassFilter.cutoffFrequency = cutoffFrequency;
    }
}
