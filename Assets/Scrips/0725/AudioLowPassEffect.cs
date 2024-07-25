using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))] //오디오 소스 컴포넌트가 반드시 필요하다.
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

        //AudioHighPassFiler 컴포넌트를 추가 하고 설정
        AudioLowPassFilter highPassFilter = gameObject.AddComponent<AudioLowPassFilter>();
        highPassFilter.cutoffFrequency = cutoffFrequency;
    }
}
