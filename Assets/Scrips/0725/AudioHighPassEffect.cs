using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))] //오디오 소스 컴포넌트가 반드시 필요하다.
public class AudioHighPassEffect : MonoBehaviour
{
    AudioSource audioSource;                            //AudioSource 컴포넌트를 저장할 변수

    //컷 오프 주파수 (Hz)
    public float cutoffFrequency = 500.0f;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();

        //AudioHighPassFiler 컴포넌트를 추가 하고 설정
        AudioHighPassFilter highPassFilter = gameObject.AddComponent<AudioHighPassFilter>();
        highPassFilter.cutoffFrequency = cutoffFrequency;
    }
}
